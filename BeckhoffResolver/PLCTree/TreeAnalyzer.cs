using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using TwinCAT.Ads.TypeSystem;
using TwinCAT.Ads;
using TwinCAT.TypeSystem;
using TwinCAT.ValueAccess;
using TwinCAT;
using BeckhoffResolver.PLCStructModel;
using BeckhoffResolver.PLCStruct;
using System.Text.RegularExpressions;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Emit;
using BeckhoffResolver.PLCSymbol;
using ORM;
using ORM.DBOperatorImpl;

namespace BeckhoffResolver.PLCTree
{
    public partial class TreeAnalyzer
    {
        public TreeAnalyzer()
        {
            dbOperator = new JsonSerializerOperator("bf");
            dbOperator.AddDerivedRelate<IPlcTypeInfo, AliasInfo>();
            dbOperator.AddDerivedRelate<IPlcTypeInfo, ArrayInfo>();
            dbOperator.AddDerivedRelate<IPlcTypeInfo, EnumInfo>();
            dbOperator.AddDerivedRelate<IPlcTypeInfo, InterfaceInfo>();
            dbOperator.AddDerivedRelate<IPlcTypeInfo, PointerInfo>();
            dbOperator.AddDerivedRelate<IPlcTypeInfo, PrimitiveInfo>();
            dbOperator.AddDerivedRelate<IPlcTypeInfo, ReferenceInfo>();
            dbOperator.AddDerivedRelate<IPlcTypeInfo, StringInfo>();
            dbOperator.AddDerivedRelate<IPlcTypeInfo, StructInfo>();
            dbOperator.AddDerivedRelate<IPlcTypeInfo, UnionInfo>();

        }

        //从json文件中导出倍福数据结构
        public void LoadFromFile()
        {
            var t = dbOperator.GetData<TreeAnalyzer>();
            this.TypeDict = t.TypeDict;
            this.RootSymbol = t.RootSymbol;
            this.DirectoryPath = t.DirectoryPath;
            this.NameSpace = t.NameSpace;
            this.RootFileName = t.RootFileName;
            this.DllName = t.DllName;
            foreach(var type in TypeDict.Values)
            {
                if(type is StructInfo si)
                {
                    foreach(var f in si.Fields)
                    {
                        f.PlcTypeInfo = TypeDict[f.TypeName];
                    }
                }
            }
        }

        //数据结构写入json文件
        public void WriteToFile()
        {
            dbOperator.SetData<TreeAnalyzer>(this);
        }

        public string DirectoryPath { get; set; }
        public string NameSpace { get; set; }
        public string RootFileName { get; set; }
        public string DllName { get; set; }

        private IDBOperator dbOperator;

        public Dictionary<string, IPlcTypeInfo> TypeDict { get; set; } = [];

        public SymbolInfo RootSymbol { get; set; } = new SymbolInfo()
        {
            InstanceName = "Root",
            TypeNameFromPLC = "Struct",
        };

        //连接倍福后，解析倍福数据结构
        public void VisitTree(string ip, int port)
        {
            TypeDict.Clear();
            using (AdsClient client = new AdsClient())
            {
                // Connect the AdsClient to the device target.
                client.Connect(new AmsAddress(ip, port));

                // Creates the Symbol Objects as hierarchical tree
                SymbolLoaderSettings settings = new SymbolLoaderSettings(SymbolsLoadMode.VirtualTree, ValueAccessMode.IndexGroupOffsetPreferred);
                ISymbolLoader symbolLoader = SymbolLoaderFactory.Create(client, settings);

                // Dump Datatypes from Target Device
                foreach (IDataType type in symbolLoader.DataTypes)
                {
                    VisitType(TypeDict, type);
                }
                foreach (IDataType type in symbolLoader.DataTypes)
                {
                    ReVisitType(TypeDict, type);
                }

                // Dump Symbols from target device
                foreach (ISymbol symbol in symbolLoader.Symbols)
                {
                    VisitSymbol(RootSymbol, symbol);
                }
            }
        }

        private void ReVisitType(Dictionary<string, IPlcTypeInfo> typeInfos, IDataType dataType)
        {
            switch (dataType.Category)
            {
                case DataTypeCategory.Alias:
                    IAliasType alias = (IAliasType)dataType;
                    if (typeInfos[dataType.Name] is AliasInfo aliasInfo)
                    {
                        aliasInfo.BaseType = typeInfos[alias.BaseTypeName];
                    }
                    break;
                case DataTypeCategory.Enum:
                    IEnumType enumType = (IEnumType)dataType;
                    if (typeInfos[dataType.Name] is EnumInfo enumInfo)
                    {
                        enumInfo.BaseType = typeInfos[enumType.BaseTypeName];
                    }
                    break;
                case DataTypeCategory.Array:
                    IArrayType array = (IArrayType)dataType;
                    if (typeInfos[dataType.Name] is ArrayInfo arrayInfo)
                    {
                        arrayInfo.ArrayInnerType = typeInfos[array.ElementTypeName];
                    }
                    break;
                case DataTypeCategory.Struct:
                    IStructType structType = (IStructType)dataType;
                    if (typeInfos[dataType.Name] is StructInfo structInfo)
                    {
                        foreach (IMember member in structType.Members)
                        {
                            structInfo.Fields.Add(new FieldInfo(member.Offset, member.InstanceName, typeInfos[member.TypeName], member.TypeName));
                        }
                    }
                    break;
            }
        }

        private void VisitType(Dictionary<string, IPlcTypeInfo> typeInfos, IDataType dataType)
        {
            switch (dataType.Category)
            {
                case DataTypeCategory.Alias:
                    IAliasType alias = (IAliasType)dataType;
                    typeInfos.Add(dataType.Name, new AliasInfo(alias.Name, alias.Namespace, alias.BaseTypeName));
                    break;
                case DataTypeCategory.Primitive:
                    IPrimitiveType primitivealias = (IPrimitiveType)dataType;
                    typeInfos.Add(dataType.Name, new PrimitiveInfo(primitivealias.Name, primitivealias.Namespace, primitivealias.BitSize));
                    break;
                case DataTypeCategory.Array:
                    IArrayType array = (IArrayType)dataType;
                    typeInfos.Add(dataType.Name, new ArrayInfo(array.Name, array.Namespace, array.Size, array.ElementTypeName, array.Dimensions.Aggregate(0, (sum, dim) => sum + dim.ElementCount)));
                    break;
                case DataTypeCategory.Struct:
                    IStructType structType = (IStructType)dataType;
                    var structInfo = new StructInfo(structType.Name, structType.Namespace, structType.Size);
                    typeInfos.Add(dataType.Name, structInfo);
                    //下一轮实现结构体字段的解析
                    //foreach (IMember member in structType.Members)
                    //{
                    //    structInfo.Fields.Add((member.Offset, member.InstanceName, typeInfos[member.TypeName]));
                    //}
                    break;
                case DataTypeCategory.Enum:
                    IEnumType enumType = (IEnumType)dataType;
                    typeInfos.Add(dataType.Name, new EnumInfo(enumType.Name, enumType.Namespace, enumType.Size, enumType.BaseTypeName, enumType.EnumValues.ToDictionary(v => v.Name, v => int.Parse(v.Primitive.ToString()!))));
                    break;
                case DataTypeCategory.String:
                    IStringType stringType = (IStringType)dataType;
                    typeInfos.Add(dataType.Name, new StringInfo(stringType.Name, stringType.Namespace, stringType.Size));
                    break;
                case DataTypeCategory.Reference:
                    IReferenceType referenceType = (IReferenceType)dataType;
                    typeInfos.Add(dataType.Name, new ReferenceInfo(referenceType.Name, referenceType.Namespace, referenceType.Size));
                    break;
                case DataTypeCategory.Pointer:
                    IPointerType pointerType = (IPointerType)dataType;
                    typeInfos.Add(dataType.Name, new PointerInfo(pointerType.Name, pointerType.Namespace, pointerType.Size));
                    break;
                case DataTypeCategory.Interface:
                    IInterfaceType interfaceType = (IInterfaceType)dataType;
                    typeInfos.Add(dataType.Name, new InterfaceInfo(interfaceType.Name, interfaceType.Namespace, interfaceType.Size));
                    break;
                case DataTypeCategory.Union:
                    IUnionType unionType = (IUnionType)dataType;
                    typeInfos.Add(dataType.Name, new UnionInfo(unionType.Name, unionType.Namespace, unionType.Size));
                    break;
                case DataTypeCategory.None:
                case DataTypeCategory.SubRange:
                case DataTypeCategory.Function:
                case DataTypeCategory.FunctionBlock:
                case DataTypeCategory.Bitset:
                case DataTypeCategory.Program:
                default:
                    break;
            }
        }


        public void VisitSymbol(SymbolInfo parentSymbol, ISymbol symbol)
        {
            var currentSymbol = GenerateSymbolInfo(symbol);

            if (symbol.Category == DataTypeCategory.Array)
            {
                currentSymbol.IsArray = true;
                IArrayInstance arrInstance = (IArrayInstance)symbol;
                //IArrayType arrType = (IArrayType)symbol.DataType!;

                foreach (ISymbol arrayElement in arrInstance.Elements)
                {
                    VisitSymbol(currentSymbol, arrayElement);
                }
            }
            else if (symbol.Category == DataTypeCategory.Struct)
            {
                IStructInstance structInstance = (IStructInstance)symbol;
                IStructType structType = (IStructType)symbol.DataType!;

                foreach (ISymbol member in structInstance.MemberInstances)
                {
                    VisitSymbol(currentSymbol, member);
                }
            }
            parentSymbol.SubSymbols.Add(currentSymbol);
        }

        private SymbolInfo GenerateSymbolInfo(ISymbol symbol)
        {
            //IDataType type = symbol.DataType!;
            SymbolInfo info = new SymbolInfo
            {
                InstanceName = symbol.InstanceName,
                TypeNameFromPLC = symbol.TypeName,
                Size = symbol.Size,
                IndexGroup = ((IAdsSymbol)symbol).IndexGroup,
                IndexOffset = ((IAdsSymbol)symbol).IndexOffset
            };
            if (symbol.Attributes.Count > 0)
            {
                info.SymbolAttributes = new HashSet<PlcAttributeInfo>();
                foreach (ITypeAttribute attribute in symbol.Attributes)
                {
                    info.SymbolAttributes.Add(new PlcAttributeInfo(attribute.Name, attribute.Value));
                }
            }
            return info;
        }

    }
}
