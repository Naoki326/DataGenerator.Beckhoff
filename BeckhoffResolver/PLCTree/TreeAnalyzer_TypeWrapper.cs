using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeckhoffResolver.PLCStruct;
using BeckhoffResolver.PLCStructModel;

namespace BeckhoffResolver.PLCTree
{
    public partial class TreeAnalyzer
    {
        public void GenerateTypeWrappers(string directoryPath, string nameSpace)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            if (!Directory.Exists(Path.Combine(directoryPath, "Wrapper")))
            {
                Directory.CreateDirectory(Path.Combine(directoryPath, "Wrapper"));
            }
            foreach (var item in TypeDict)
            {
                switch (item.Value.DataType)
                {
                    case DataTypeEnum.Struct:
                        GenerateStructWrapper(Path.Combine(directoryPath, "Wrapper", item.Key.MakeValidFileName() + "Wrapper.cs"), nameSpace, (StructInfo)item.Value);
                        break;
                    case DataTypeEnum.Enum:
                        break;
                    case DataTypeEnum.Primitive:
                        break;
                }
            }
        }

        private void GenerateStructWrapper(string fileName, string nameSpace, StructInfo type)
        {
            int tabCount = 0;
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("using System.Runtime.InteropServices;");
                    sw.WriteLine("using System.Collections.Generic;");
                    sw.WriteLine("using TwinCAT.Ads;");
                    sw.WriteLine($"using {nameSpace}.Enum;");
                    sw.WriteLine($"using {nameSpace}.Struct;");
                    sw.WriteLine("using PlcCore.Beckhoff;");
                    sw.WriteLine($"using PlcCore.Data;");
                    sw.WriteLine();
                    sw.WriteLine($"namespace {nameSpace}.Wrapper");
                    sw.WriteLine("{");
                    tabCount++;
                    sw.WriteLine(tabCount.GetTabs() + $"/// <summary>");
                    sw.WriteLine(tabCount.GetTabs() + $"/// Name from PLC:{type.Name}");
                    sw.WriteLine(tabCount.GetTabs() + $"/// PLCNamespace from PLC: {type.NameSpace}");
                    sw.WriteLine(tabCount.GetTabs() + $"/// Size: {type.Size}");
                    if (type.TypeAttributes != null && type.TypeAttributes.Count > 0)
                    {
                        foreach (var attribute in type.TypeAttributes)
                        {
                            sw.WriteLine(tabCount.GetTabs() + $"/// {attribute.ToAttributeString()}");
                        }
                    }
                    sw.WriteLine(tabCount.GetTabs() + $"/// Comment from PLC: {type.TypeComment}");
                    sw.WriteLine(tabCount.GetTabs() + $"/// <summary>");
                    var tStructName = type.Name.ConvertFieldDefinition();
                    sw.WriteLine(tabCount.GetTabs() + $"public partial class {tStructName.WrapperSubffix()} : BeckhoffStruct<{tStructName.WrapperSubffix()}, {tStructName}>");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    tabCount++;

                    sw.WriteLine(tabCount.GetTabs() + "");

                    sw.WriteLine(tabCount.GetTabs() + $"public {tStructName.WrapperSubffix()}(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    sw.WriteLine(tabCount.GetTabs() + "}");
                    sw.WriteLine(tabCount.GetTabs() + "");

                    foreach (var field in type.Fields)
                    {
                        GenerateFieldWrapper(sw, tabCount, field);
                    }

                    sw.WriteLine(tabCount.GetTabs() + "protected override IEnumerable<IBaseData> GetChildren()");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    tabCount++;
                    foreach (var field in type.Fields)
                    {
                        switch (field.PlcTypeInfo.DataType)
                        {
                            case DataTypeEnum.Primitive:
                                sw.WriteLine(tabCount.GetTabs() + $"yield return {field.InstanceName};");
                                break;
                            case DataTypeEnum.Alias:
                                sw.WriteLine(tabCount.GetTabs() + $"yield return {field.InstanceName};");
                                break;
                            case DataTypeEnum.Struct:
                                sw.WriteLine(tabCount.GetTabs() + $"yield return {field.InstanceName};");
                                break;
                            case DataTypeEnum.Array:
                                sw.WriteLine(tabCount.GetTabs() + $"yield return {field.InstanceName};");
                                break;
                            case DataTypeEnum.String:
                                sw.WriteLine(tabCount.GetTabs() + $"yield return {field.InstanceName};");
                                break;
                            case DataTypeEnum.Enum:
                                sw.WriteLine(tabCount.GetTabs() + $"yield return {field.InstanceName};");
                                break;
                            case DataTypeEnum.Reference:
                            case DataTypeEnum.Pointer:
                            case DataTypeEnum.Interface:
                                //sw.WriteLine(tabCount.GetTabs() + $"// pointer or reference");
                                //sw.WriteLine(tabCount.GetTabs() + $"public byte {field.Item2};");
                                //sw.WriteLine();
                                break;
                            case DataTypeEnum.Union:
                                break;
                        }
                    }
                    tabCount--;
                    sw.WriteLine(tabCount.GetTabs() + "}");
                    sw.WriteLine();


                    sw.WriteLine(tabCount.GetTabs() + "public override IBaseData Get(string name)");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    tabCount++;
                    sw.WriteLine(tabCount.GetTabs() + "switch (name)");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    tabCount++;
                    foreach (var field in type.Fields)
                    {
                        switch (field.PlcTypeInfo.DataType)
                        {
                            case DataTypeEnum.Primitive:
                            case DataTypeEnum.Alias:
                            case DataTypeEnum.Struct:
                            case DataTypeEnum.Array:
                            case DataTypeEnum.String:
                            case DataTypeEnum.Enum:
                                sw.WriteLine(tabCount.GetTabs() + $"case nameof({field.InstanceName}):");
                                sw.WriteLine((tabCount + 1).GetTabs() + $"return {field.InstanceName};");
                                break;
                            case DataTypeEnum.Reference:
                            case DataTypeEnum.Pointer:
                            case DataTypeEnum.Interface:
                            case DataTypeEnum.Union:
                                break;
                        }
                    }
                    tabCount--;
                    sw.WriteLine(tabCount.GetTabs() + "}");
                    sw.WriteLine(tabCount.GetTabs() + $"throw new KeyNotFoundException(name);");
                    tabCount--;
                    sw.WriteLine(tabCount.GetTabs() + "}");

                    sw.WriteLine();
                    tabCount--;
                    sw.WriteLine(tabCount.GetTabs() + "}");
                    tabCount--;
                    sw.WriteLine("}");
                }
            }
        }

        private void GenerateFieldWrapper(StreamWriter sw, int tabCount, FieldInfo field)
        {
            switch (field.PlcTypeInfo.DataType)
            {
                case DataTypeEnum.Primitive:
                    var primitiveInfo = (PrimitiveInfo)field.PlcTypeInfo;
                    sw.WriteLine(tabCount.GetTabs() + $"public IBaseData<{primitiveInfo.GetCSharpName()}> {field.InstanceName} {{ get; init; }}");
                    //sw.WriteLine(ClassDefineHelper.GetTabs(tabCount + 1) + $" = new BaseData<{primitiveInfo.GetCSharpName()}>({parent.IndexGroup},{parent.IndexOffset});");
                    sw.WriteLine();
                    break;
                case DataTypeEnum.Alias:
                    var aliasInfo = (AliasInfo)field.PlcTypeInfo;
                    GenerateFieldWrapper(sw, tabCount, new FieldInfo(field.Offset, field.InstanceName, aliasInfo.BaseType));
                    break;
                case DataTypeEnum.Struct:
                    sw.WriteLine(tabCount.GetTabs() + $"public {field.PlcTypeInfo.Name.ConvertFieldDefinition().WrapperSubffix()} {field.InstanceName} {{ get; init; }}");
                    sw.WriteLine();
                    break;
                case DataTypeEnum.Array:
                    var arrayInfo = (ArrayInfo)field.PlcTypeInfo;
                    var length = arrayInfo.ArrayLength;
                    var itemType = arrayInfo.ArrayInnerType!.GetBaseType();
                    string arrItemTypeName = itemType.Name.ConvertFieldDefinition().ToCSharpTypeName().CapitalizeFirstLetter();
                    if (ClassDefineHelper.ConvertArrayDefinition(arrayInfo.ArrayInnerType!.GetBaseType().Name, out string? result))
                    {
                        if (arrayInfo.ArrayInnerType!.GetBaseType() is PrimitiveInfo)
                        {
                            sw.WriteLine(tabCount.GetTabs() + $"public IBaseArray<{arrItemTypeName}{length}, {result.ToCSharpTypeName()}> {field.InstanceName}{{ get; init; }}");
                        }
                        else
                        {
                            sw.WriteLine(tabCount.GetTabs() + $"public IStructArray<{result!.ToCSharpTypeName().NoWrapperSubffix()}{length}, {result.ToCSharpTypeName().WrapperSubffix()}, {result.ToCSharpTypeName()}> {field.InstanceName}{{ get; init; }}");
                        }
                    }
                    else
                    {
                        if (arrayInfo.ArrayInnerType!.GetBaseType() is PrimitiveInfo)
                        {
                            sw.WriteLine(tabCount.GetTabs() + $"public IBaseArray<{arrItemTypeName}{length}, {arrayInfo.ArrayInnerType.GetBaseType().Name.ConvertFieldDefinition().ToCSharpTypeName()}> {field.InstanceName}{{ get; init; }}");
                        }
                        else
                        {
                            sw.WriteLine(tabCount.GetTabs() + $"public IStructArray<{arrayInfo.ArrayInnerType.GetBaseType().Name.ConvertFieldDefinition().ToCSharpTypeName().NoWrapperSubffix()}{length}, {arrayInfo.ArrayInnerType.GetBaseType().Name.ConvertFieldDefinition().ToCSharpTypeName().WrapperSubffix()}, {arrayInfo.ArrayInnerType.GetBaseType().Name.ConvertFieldDefinition().ToCSharpTypeName()}> {field.InstanceName}{{ get; init; }}");
                        }
                    }
                    sw.WriteLine();
                    break;
                case DataTypeEnum.String:
                    var stringInfo = (StringInfo)field.PlcTypeInfo;
                    sw.WriteLine(tabCount.GetTabs() + $"public IBaseString {field.InstanceName}{{ get; init; }}");
                    sw.WriteLine();
                    break;
                case DataTypeEnum.Enum:
                    var enumInfo = (EnumInfo)field.PlcTypeInfo;
                    sw.WriteLine(tabCount.GetTabs() + $"public IBaseData<{enumInfo.Name.ConvertFieldDefinition()}> {field.InstanceName}{{ get; init; }}");
                    sw.WriteLine();
                    break;
                case DataTypeEnum.Reference:
                case DataTypeEnum.Pointer:
                case DataTypeEnum.Interface:
                    //sw.WriteLine(tabCount.GetTabs() + $"// pointer or reference");
                    //sw.WriteLine(tabCount.GetTabs() + $"public byte {field.Item2};");
                    //sw.WriteLine();
                    break;
                case DataTypeEnum.Union:
                    break;
            }
            //sw.WriteLine(tabCount.GetTabs() + "");
        }
    }
}
