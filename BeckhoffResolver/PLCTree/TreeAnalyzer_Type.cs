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

namespace BeckhoffResolver.PLCTree
{
    public partial class TreeAnalyzer
    {
        public void GenerateTypes(string directoryPath, string nameSpace)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            foreach (var item in TypeDict)
            {
                switch (item.Value.DataType)
                {
                    case DataTypeEnum.Struct:
                        if (!Directory.Exists(Path.Combine(directoryPath, "Struct")))
                        {
                            Directory.CreateDirectory(Path.Combine(directoryPath, "Struct"));
                        }
                        GenerateStruct(directoryPath, Path.Combine(directoryPath, "Struct", item.Key.MakeValidFileName() + ".cs"), nameSpace, (StructInfo)item.Value);
                        break;
                    case DataTypeEnum.Enum:
                        if (!Directory.Exists(Path.Combine(directoryPath, "Enum")))
                        {
                            Directory.CreateDirectory(Path.Combine(directoryPath, "Enum"));
                        }
                        GenerateEnum(Path.Combine(directoryPath, "Enum", item.Key.MakeValidFileName() + ".cs"), nameSpace, (EnumInfo)item.Value);
                        break;
                    case DataTypeEnum.Array:
                        GeneratePLCStructArray(directoryPath, nameSpace, (ArrayInfo)item.Value);
                        break;
                    case DataTypeEnum.String:
                        var stringInfo = (StringInfo)item.Value;
                        GeneratePLCString(directoryPath, nameSpace, stringInfo);
                        break;
                }
            }
        }

        private void GenerateEnum(string fileName, string nameSpace, EnumInfo type)
        {
            int tabCount = 0;
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("using System;");
                    sw.WriteLine("using System.Runtime.InteropServices;");
                    sw.WriteLine();
                    sw.WriteLine($"namespace {nameSpace}.Enum");
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
                    sw.WriteLine(tabCount.GetTabs() + $"public enum {type.Name.ConvertFieldDefinition()} : {type.BaseType.GetBaseType().Name.ToCSharpTypeName()}");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    tabCount++;

                    foreach (var enumKV in type.Values)
                    {
                        sw.WriteLine(tabCount.GetTabs() + $"{enumKV.Key} = {enumKV.Value},");
                    }

                    sw.WriteLine();
                    tabCount--;
                    sw.WriteLine(tabCount.GetTabs() + "}");
                    tabCount--;
                    sw.WriteLine("}");
                }
            }
        }

        private void GenerateStruct(string directoryPath, string fileName, string nameSpace, StructInfo type)
        {
            int tabCount = 0;
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("using System;");
                    sw.WriteLine("using System.Runtime.InteropServices;");
                    sw.WriteLine("using System.Diagnostics;");
                    sw.WriteLine($"using {nameSpace}.Enum;");
                    sw.WriteLine();
                    sw.WriteLine($"namespace {nameSpace}.Struct");
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
                    sw.WriteLine(tabCount.GetTabs() + @"[StructLayout(LayoutKind.Explicit)]");
                    sw.WriteLine(tabCount.GetTabs() + $"public struct {type.Name.ConvertFieldDefinition()}");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    tabCount++;


                    sw.WriteLine(tabCount.GetTabs() + $"public {type.Name.ConvertFieldDefinition()}()");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    sw.WriteLine(tabCount.GetTabs() + "}");
                    sw.WriteLine();

                    foreach (var field in type.Fields)
                    {
                        GenerateField(directoryPath, nameSpace, sw, tabCount, field);
                    }

                    sw.WriteLine();
                    tabCount--;
                    sw.WriteLine(tabCount.GetTabs() + "}");
                    tabCount--;
                    sw.WriteLine("}");
                }
            }
        }

        private void GenerateField(string directoryPath, string nameSpace, StreamWriter sw, int tabCount, FieldInfo field)
        {
            switch (field.PlcTypeInfo.DataType)
            {
                case DataTypeEnum.Primitive:
                    sw.WriteLine(tabCount.GetTabs() + $"[FieldOffset({field.Offset})]");
                    var primitiveInfo = (PrimitiveInfo)field.PlcTypeInfo;
                    if (primitiveInfo.TryGetMarshalAttribute(out var marshalInfo))
                    {
                        sw.WriteLine(tabCount.GetTabs() + $"[MarshalAs({marshalInfo})]");
                    }
                    sw.WriteLine(tabCount.GetTabs() + $"public {primitiveInfo.GetCSharpName()} {field.InstanceName};");
                    sw.WriteLine();
                    break;
                case DataTypeEnum.Alias:
                    var aliasInfo = (AliasInfo)field.PlcTypeInfo;
                    GenerateField(directoryPath, nameSpace, sw, tabCount, new FieldInfo(field.Offset, field.InstanceName, aliasInfo.BaseType));
                    break;
                case DataTypeEnum.Struct:
                    sw.WriteLine(tabCount.GetTabs() + $"[FieldOffset({field.Offset})]");
                    sw.WriteLine(tabCount.GetTabs() + $"public {field.PlcTypeInfo.Name.ConvertFieldDefinition()} {field.InstanceName} = new {field.PlcTypeInfo.Name.ConvertFieldDefinition()}();");
                    sw.WriteLine();
                    break;
                case DataTypeEnum.Array:
                    GeneratePLCStructArray(directoryPath, nameSpace, (ArrayInfo)field.PlcTypeInfo);
                    sw.WriteLine(tabCount.GetTabs() + $"[FieldOffset({field.Offset})]");
                    var arrayInfo = (ArrayInfo)field.PlcTypeInfo;
                    //sw.WriteLine(tabCount.GetTabs() + $"[MarshalAs(UnmanagedType.ByValArray, SizeConst = {arrayInfo.ArrayLength})]");
                    string arrItemTypeName = arrayInfo.ArrayInnerType!.GetBaseType().Name.ConvertFieldDefinition().ToCSharpTypeName().CapitalizeFirstLetter();
                    sw.WriteLine(tabCount.GetTabs() + $"public {arrItemTypeName}{arrayInfo.ArrayLength} {field.InstanceName} = new {arrItemTypeName}{arrayInfo.ArrayLength}();");
                    sw.WriteLine();
                    break;
                case DataTypeEnum.String:
                    var stringInfo = (StringInfo)field.PlcTypeInfo;
                    GeneratePLCString(directoryPath, nameSpace, stringInfo);
                    sw.WriteLine(tabCount.GetTabs() + $"[FieldOffset({field.Offset})]");
                    sw.WriteLine(tabCount.GetTabs() + $"public String{stringInfo.Size} {field.InstanceName};");
                    sw.WriteLine();
                    break;
                case DataTypeEnum.Enum:
                    sw.WriteLine(tabCount.GetTabs() + $"[FieldOffset({field.Offset})]");
                    var enumInfo = (EnumInfo)field.PlcTypeInfo;
                    sw.WriteLine(tabCount.GetTabs() + $"public {enumInfo.Name.ConvertFieldDefinition()} {field.InstanceName};");
                    sw.WriteLine();
                    break;
                case DataTypeEnum.Reference:
                case DataTypeEnum.Pointer:
                    sw.WriteLine(tabCount.GetTabs() + $"[FieldOffset({field.Offset})]");
                    sw.WriteLine(tabCount.GetTabs() + $"// pointer or reference");
                    sw.WriteLine(tabCount.GetTabs() + $"[Obsolete(\"PLC reference not used\")]");
                    sw.WriteLine(tabCount.GetTabs() + $"public byte {field.InstanceName};");
                    sw.WriteLine();
                    break;
                case DataTypeEnum.Interface:
                    sw.WriteLine(tabCount.GetTabs() + $"[FieldOffset({field.Offset})]");
                    sw.WriteLine(tabCount.GetTabs() + $"// interface");
                    sw.WriteLine(tabCount.GetTabs() + $"[Obsolete(\"PLC Interface not used\")]");
                    sw.WriteLine(tabCount.GetTabs() + $"public long {field.InstanceName};");
                    sw.WriteLine();
                    break;
                case DataTypeEnum.Union:

                    break;
            }
            //sw.WriteLine(tabCount.GetTabs() + "");
        }
    }
}
