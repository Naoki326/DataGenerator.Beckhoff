using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeckhoffResolver.PLCStruct;
using BeckhoffResolver.PLCStructModel;
using BeckhoffResolver.PLCSymbol;
using TwinCAT.Ads.TypeSystem;

namespace BeckhoffResolver.PLCTree
{
    public partial class TreeAnalyzer
    {
        private void GenerateRootClass(string directoryPath, string nameSpace, SymbolInfo subRoot)
        {
            var fileName = Path.Combine(directoryPath, $"{subRoot.InstanceName.WrapperSubffix()}.cs");

            int tabCount = 0;
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("using System.Runtime.InteropServices;");
                    sw.WriteLine("using System.Threading;");
                    sw.WriteLine($"using {nameSpace}.Enum;");
                    sw.WriteLine($"using {nameSpace}.Struct;");
                    sw.WriteLine($"using {nameSpace}.Wrapper;");
                    sw.WriteLine("using PlcCore.Beckhoff;");
                    sw.WriteLine($"using PlcCore.Data;");
                    sw.WriteLine();
                    sw.WriteLine($"namespace {nameSpace}.Root");
                    sw.WriteLine("{");

                    tabCount++;

                    sw.WriteLine("");
                    sw.WriteLine(tabCount.GetTabs() + $"/// <summary>");
                    sw.WriteLine(tabCount.GetTabs() + $"/// Name from PLC:{subRoot.InstanceName}");
                    sw.WriteLine(tabCount.GetTabs() + $"/// TypeName from PLC: {subRoot.TypeNameFromPLC}");
                    sw.WriteLine(tabCount.GetTabs() + $"/// (IndexGroup, IndexOffset): ({subRoot.IndexGroup},{subRoot.IndexOffset})");
                    sw.WriteLine(tabCount.GetTabs() + $"/// Size: {subRoot.Size}");
                    sw.WriteLine(tabCount.GetTabs() + $"/// IsArray: {subRoot.IsArray}");

                    sw.WriteLine(tabCount.GetTabs() + "");
                    sw.WriteLine(tabCount.GetTabs() + $"public sealed partial class {subRoot.InstanceName.WrapperSubffix()}");
                    sw.WriteLine(tabCount.GetTabs() + "{");

                    tabCount++;

                    foreach (var subSymbol in subRoot.GetUsedSubSymbols())
                    {
                        if (subSymbol.IsArray)
                        {
                            var typeInfo = TypeDict[subSymbol.TypeNameFromPLC].GetBaseType();
                            var itemInfo = ((ArrayInfo)typeInfo).ArrayInnerType!.GetBaseType();
                            if (itemInfo is PrimitiveInfo primitiveType)
                            {
                                GenerateSubIBaseArray(directoryPath, nameSpace, sw, tabCount, subSymbol, primitiveType, ((ArrayInfo)typeInfo).ArrayLength);
                            }
                            else if (itemInfo is EnumInfo enumType)
                            {
                                GenerateSubIEnumArray(directoryPath, nameSpace, sw, tabCount, subSymbol, enumType, ((ArrayInfo)typeInfo).ArrayLength);
                            }
                            else if (itemInfo is StructInfo structType)
                            {
                                GenerateSubIArray(directoryPath, nameSpace, sw, tabCount, subSymbol, structType, ((ArrayInfo)typeInfo).ArrayLength);
                            }
                        }
                        else
                        {
                            var typeInfo = TypeDict[subSymbol.TypeNameFromPLC].GetBaseType();
                            if (typeInfo is PrimitiveInfo primitiveType)
                            {
                                GenerateSubIBaseField(directoryPath, nameSpace, sw, tabCount, subSymbol, primitiveType);
                            }
                            else if (typeInfo is EnumInfo enumType)
                            {
                                GenerateSubIEnumField(directoryPath, nameSpace, sw, tabCount, subSymbol, enumType);
                            }
                            else if (typeInfo is StructInfo structType)
                            {
                                GenerateSubIField(directoryPath, nameSpace, sw, tabCount, subSymbol, structType);
                            }
                            else if(typeInfo is PLCStruct.StringInfo stringType)
                            {
                                GenerateSubIStringField(directoryPath, nameSpace, sw, tabCount, subSymbol, stringType);
                            }
                        }
                    }

                    sw.WriteLine("");
                    sw.WriteLine(tabCount.GetTabs() + "internal override void Init()");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    sw.WriteLine(tabCount.GetTabs() + "}");

                    sw.WriteLine(tabCount.GetTabs() + "public override void CheckAndNotify(int timeout = -1, CancellationToken token = default)");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    sw.WriteLine(tabCount.GetTabs() + "    foreach (var child in Children)");
                    sw.WriteLine(tabCount.GetTabs() + "    {");
                    sw.WriteLine(tabCount.GetTabs() + "        child?.CheckAndNotify(timeout, token);");
                    sw.WriteLine(tabCount.GetTabs() + "    }");
                    sw.WriteLine(tabCount.GetTabs() + "}");
                    sw.WriteLine();

                    tabCount--;

                    sw.WriteLine("");
                    sw.WriteLine(tabCount.GetTabs() + "}");

                    tabCount--;

                    sw.WriteLine("");
                    sw.WriteLine("}");
                }
            }
        }

        private void GenerateSubIBaseField(string directoryPath, string nameSpace, StreamWriter sw, int tabCount, SymbolInfo parent, PrimitiveInfo primitiveType)
        {
            sw.WriteLine("");
            sw.WriteLine(tabCount.GetTabs() + $"/// <summary>");
            sw.WriteLine(tabCount.GetTabs() + $"/// Name from PLC:{parent.InstanceName}");
            sw.WriteLine(tabCount.GetTabs() + $"/// TypeName from PLC: {parent.TypeNameFromPLC}");
            sw.WriteLine(tabCount.GetTabs() + $"/// (IndexGroup, IndexOffset): ({parent.IndexGroup},{parent.IndexOffset})");
            sw.WriteLine(tabCount.GetTabs() + $"/// Size: {parent.Size}");

            var csharpTypeName = primitiveType.Name.ToCSharpTypeName();
            sw.WriteLine(tabCount.GetTabs() + $"public IBaseData<{csharpTypeName}> {parent.InstanceName} {{ get; }}");
            sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + $"internal {csharpTypeName} ref_{parent.InstanceName} = new {csharpTypeName}();");
        }

        private void GenerateSubIEnumField(string directoryPath, string nameSpace, StreamWriter sw, int tabCount, SymbolInfo parent, EnumInfo enumType)
        {
            sw.WriteLine("");
            sw.WriteLine(tabCount.GetTabs() + $"/// <summary>");
            sw.WriteLine(tabCount.GetTabs() + $"/// Name from PLC:{parent.InstanceName}");
            sw.WriteLine(tabCount.GetTabs() + $"/// TypeName from PLC: {parent.TypeNameFromPLC}");
            sw.WriteLine(tabCount.GetTabs() + $"/// (IndexGroup, IndexOffset): ({parent.IndexGroup},{parent.IndexOffset})");
            sw.WriteLine(tabCount.GetTabs() + $"/// Size: {parent.Size}");

            var csharpTypeName = enumType.Name.NoWrapperSubffix();
            sw.WriteLine(tabCount.GetTabs() + $"public IBaseData<{csharpTypeName}> {parent.InstanceName} {{ get; }}");
            sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + $"internal {csharpTypeName}  ref_{parent.InstanceName} = new {csharpTypeName}();");
        }

        private void GenerateSubIStringField(string directoryPath, string nameSpace, StreamWriter sw, int tabCount, SymbolInfo parent, PLCStruct.StringInfo stringType)
        {
            sw.WriteLine(tabCount.GetTabs() + $"public BeckhoffString<String{stringType.Size}> {parent.InstanceName};");
            sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + $"internal String{stringType.Size}  ref_{parent.InstanceName} = new String{stringType.Size}();");
            sw.WriteLine();
        }

        private void GenerateSubIField(string directoryPath, string nameSpace, StreamWriter sw, int tabCount, SymbolInfo parent, StructInfo structType)
        {
            sw.WriteLine("");
            sw.WriteLine(tabCount.GetTabs() + $"/// <summary>");
            sw.WriteLine(tabCount.GetTabs() + $"/// Name from PLC:{parent.InstanceName}");
            sw.WriteLine(tabCount.GetTabs() + $"/// TypeName from PLC: {parent.TypeNameFromPLC}");
            sw.WriteLine(tabCount.GetTabs() + $"/// (IndexGroup, IndexOffset): ({parent.IndexGroup},{parent.IndexOffset})");
            sw.WriteLine(tabCount.GetTabs() + $"/// Size: {parent.Size}");

            sw.WriteLine(tabCount.GetTabs() + $"public {structType.Name.WrapperSubffix()} {parent.InstanceName} {{ get; }}");
            sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + $"internal {structType.Name.ConvertFieldDefinition()} ref_{parent.InstanceName} = new {structType.Name.ConvertFieldDefinition()}();");
        }

        private void GenerateSubIBaseArray(string directoryPath, string nameSpace, StreamWriter sw, int tabCount, SymbolInfo parent, PrimitiveInfo primitiveType, int arrayLength)
        {
            sw.WriteLine("");
            sw.WriteLine(tabCount.GetTabs() + $"/// <summary>");
            sw.WriteLine(tabCount.GetTabs() + $"/// Name from PLC:{parent.InstanceName}");
            sw.WriteLine(tabCount.GetTabs() + $"/// TypeName from PLC: {parent.TypeNameFromPLC}");
            sw.WriteLine(tabCount.GetTabs() + $"/// (IndexGroup, IndexOffset): ({parent.IndexGroup},{parent.IndexOffset})");
            sw.WriteLine(tabCount.GetTabs() + $"/// Size: {parent.Size}");

            var csharpTypeName = primitiveType.Name.ToCSharpTypeName();
            sw.WriteLine(tabCount.GetTabs() + $"public IBaseArray<{csharpTypeName.ConvertFieldDefinition().ToCSharpTypeName().CapitalizeFirstLetter()}{arrayLength}, {csharpTypeName}> {parent.InstanceName} {{ get; }}");
            sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + $"internal {csharpTypeName.ConvertFieldDefinition().ToCSharpTypeName().CapitalizeFirstLetter()}{arrayLength} ref_{parent.InstanceName} = new {csharpTypeName.ConvertFieldDefinition().ToCSharpTypeName().CapitalizeFirstLetter()}{arrayLength}();");
        }

        private void GenerateSubIEnumArray(string directoryPath, string nameSpace, StreamWriter sw, int tabCount, SymbolInfo parent, EnumInfo enumType, int arrayLength)
        {
            sw.WriteLine("");
            sw.WriteLine(tabCount.GetTabs() + $"/// <summary>");
            sw.WriteLine(tabCount.GetTabs() + $"/// Name from PLC:{parent.InstanceName}");
            sw.WriteLine(tabCount.GetTabs() + $"/// TypeName from PLC: {parent.TypeNameFromPLC}");
            sw.WriteLine(tabCount.GetTabs() + $"/// (IndexGroup, IndexOffset): ({parent.IndexGroup},{parent.IndexOffset})");
            sw.WriteLine(tabCount.GetTabs() + $"/// Size: {parent.Size}");

            var csharpTypeName = enumType.Name.NoWrapperSubffix();
            sw.WriteLine(tabCount.GetTabs() + $"public IBaseArray<{csharpTypeName}{arrayLength}, {csharpTypeName}> {parent.InstanceName} {{ get; }}");
            sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + $"internal {csharpTypeName}{arrayLength} ref_{parent.InstanceName} = new {csharpTypeName}{arrayLength};");
        }

        private void GenerateSubIArray(string directoryPath, string nameSpace, StreamWriter sw, int tabCount, SymbolInfo parent, StructInfo structType, int arrayLength)
        {
            sw.WriteLine("");
            sw.WriteLine(tabCount.GetTabs() + $"/// <summary>");
            sw.WriteLine(tabCount.GetTabs() + $"/// Name from PLC:{parent.InstanceName}");
            sw.WriteLine(tabCount.GetTabs() + $"/// TypeName from PLC: {parent.TypeNameFromPLC}");
            sw.WriteLine(tabCount.GetTabs() + $"/// (IndexGroup, IndexOffset): ({parent.IndexGroup},{parent.IndexOffset})");
            sw.WriteLine(tabCount.GetTabs() + $"/// Size: {parent.Size}");
            sw.WriteLine(tabCount.GetTabs() + $"public IStructArray<{structType.Name.ConvertFieldDefinition()}{arrayLength}, {structType.Name.WrapperSubffix()}, {structType.Name.ConvertFieldDefinition()}> {parent.InstanceName} {{ get; }}");
            sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + $"internal {structType.Name.ConvertFieldDefinition()}{arrayLength} ref_{parent.InstanceName} = new {structType.Name.ConvertFieldDefinition()}{arrayLength}();");
            //sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + $"{{");
            //tabCount++;
            //foreach(var i in Enumerable.Range(0, arrayLength))
            //{
            //    sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + $"new {structType.Name.ConvertFieldDefinition()}(),");
            //}
            //tabCount--;
            //sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + $"}};");
            //sw.WriteLine(ClassDefineHelper.GetTabs(tabCount+1) + $" = new {WrapperSubffix(structType.Name)}({parent.IndexGroup},{parent.IndexOffset});");
        }
    }
}
