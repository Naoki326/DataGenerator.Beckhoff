using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using BeckhoffResolver.PLCStructModel;
using BeckhoffResolver.PLCSymbol;
using TwinCAT.Ads.TypeSystem;
using TwinCAT.TypeSystem;
using BeckhoffResolver.PLCStruct;
using System.Reflection;

namespace BeckhoffResolver.PLCTree
{
    internal enum SegmentType
    {
        Name,
        Dot,
        Index,
        VirtualIndex,
    }
    internal class CurrentSegment
    {
        public string Segment { get; set; } = default!;

        public SegmentType Type { get; set; } = SegmentType.Name;

        public string ToGetName()
        {
            switch (Type)
            {
                case SegmentType.Name:
                    return Segment;
                case SegmentType.Dot:
                    return "_Dot_";
                case SegmentType.Index:
                    return $"_At{Segment}_";
            }
            return Segment;
        }

        public string ToGetString()
        {
            switch (Type)
            {
                case SegmentType.Name:
                    return Segment;
                case SegmentType.Dot:
                    return ".";
                case SegmentType.Index:
                    return $"[{Segment}]";
                case SegmentType.VirtualIndex:
                    return $".Item_{Segment}";
            }
            return Segment;
        }
    }

    internal class CurrentSegments
    {
        private List<CurrentSegment> segments { get; init; } = [];

        public void AddName(string name)
        {
            if (segments.Count == 0)
            {
                segments.Add(new CurrentSegment() { Type = SegmentType.Name, Segment = name }); 
            }
            else
            {
                segments.Add(new CurrentSegment() { Type = SegmentType.Dot });
                segments.Add(new CurrentSegment() { Type = SegmentType.Name, Segment = name });
            }
        }

        public void AddIndex(int index)
        {
            //if (segments.Count == 1)
            //{
            //    segments.Add(new CurrentSegment() { Type = SegmentType.Index, Segment = index.ToString() });
            //}
            //else
            {
                segments.Add(new CurrentSegment() { Type = SegmentType.VirtualIndex, Segment = index.ToString() });
            }
        }

        public bool IsRoot()
        {
            return segments.Count == 1;
        }

        public CurrentSegments GetCopy()
        {
            return new CurrentSegments()
            {
                segments = new List<CurrentSegment>(this.segments)
            };
        }

        public string ToGetName()
        {
            return segments.Select(p => p.ToGetName()).Aggregate((p, q) => p + q);
        }

        public string ToGetString()
        {
            return segments.Select(p => p.ToGetString()).Aggregate((p, q) => p + q);
        }
    }

    public partial class TreeAnalyzer
    {

        int methodCount = 0;

        private void BeginGet(StreamWriter sw, int tabCount)
        {
            methodCount++;
            if(methodCount > 50000)
            {
                sw.WriteLine("");
                sw.WriteLine(tabCount.GetTabs() + "}");
                sw.WriteLine(tabCount.GetTabs() + "");
                sw.WriteLine(tabCount.GetTabs() + $"internal static class GetClass_{Guid.NewGuid():N}");
                sw.WriteLine(tabCount.GetTabs() + "{");
                methodCount = 0;
            }
        }

        private void EndGet(StreamWriter sw, int tabCount)
        {
            
        }



        private void GenerateGet(string directoryPath, string nameSpace, StreamWriter sw, int tabCount, SymbolInfo symbol, CurrentSegments current, string parentClassName, bool isRoot = true)
        {
            isRoot = false;
            foreach (var subSymbol in symbol.GetUsedSubSymbols())
            {
                if (subSymbol.IsArray)
                {
                    var typeInfo = TypeDict[subSymbol.TypeNameFromPLC].GetBaseType();
                    var itemInfo = ((ArrayInfo)typeInfo).ArrayInnerType!.GetBaseType();
                    var length = ((ArrayInfo)typeInfo).ArrayLength;
                    if (itemInfo is PrimitiveInfo primitiveType)
                    {
                        CurrentSegments other = current.GetCopy();
                        other.AddName(subSymbol.InstanceName);
                        GeneratePrimitiveArrayGetDataDel(directoryPath, nameSpace, sw, tabCount, subSymbol, primitiveType, other, length, parentClassName, isRoot);
                    }
                    else if (typeInfo is StringInfo stringType)
                    {
                        CurrentSegments other = current.GetCopy();
                        other.AddName(subSymbol.InstanceName);
                        if(isRoot)
                        {
                            BeginGet(sw, tabCount);
                            sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + $"internal static ref string[] Get{current.ToGetName()}(this {parentClassName} parent) => ref parent.ref_{other.ToGetString()};");
                            EndGet(sw, tabCount);
                        }
                        else
                        {
                            BeginGet(sw, tabCount);
                            sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + $"internal static ref String{length} Get{current.ToGetName()}(this {parentClassName} parent) => ref parent.ref_{other.ToGetString()};");
                            EndGet(sw, tabCount);
                        }
                    }
                    else if (typeInfo is EnumInfo enumType)
                    {
                        CurrentSegments other = current.GetCopy();
                        other.AddName(subSymbol.InstanceName);
                        if (isRoot)
                        {
                            BeginGet(sw, tabCount);
                            sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + $"internal static ref {enumType.Name.NoWrapperSubffix()}[] Get{current.ToGetName()}(this {parentClassName} parent) => ref parent.ref_{other.ToGetString()};");
                            EndGet(sw, tabCount);
                        }
                        else
                        {
                            BeginGet(sw, tabCount);
                            sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + $"internal static ref {enumType.Name.NoWrapperSubffix().CapitalizeFirstLetter()}{length} Get{current.ToGetName()}(this {parentClassName} parent) => ref parent.ref_{other.ToGetString()};");
                            EndGet(sw, tabCount);
                        }
                    }
                    else if (itemInfo is StructInfo structType)
                    {
                        CurrentSegments other = current.GetCopy();
                        other.AddName(subSymbol.InstanceName);
                        GenerateStructArrayGetDataDel(directoryPath, nameSpace, sw, tabCount, subSymbol, structType, other, length, parentClassName, isRoot);
                    }
                }
                else
                {
                    var typeInfo = TypeDict[subSymbol.TypeNameFromPLC].GetBaseType();
                    if (typeInfo is PrimitiveInfo primitiveType)
                    {
                        CurrentSegments other = current.GetCopy();
                        other.AddName(subSymbol.InstanceName);
                        GeneratePrimitiveGetDataDel(directoryPath, nameSpace, sw, tabCount, subSymbol, primitiveType, other, parentClassName);
                    }
                    else if(typeInfo is StringInfo stringType)
                    {
                        CurrentSegments other = current.GetCopy();
                        other.AddName(subSymbol.InstanceName);
                        GenerateStringGetDataDel(directoryPath, nameSpace, sw, tabCount, subSymbol, stringType, other, parentClassName, isRoot);
                    }
                    else if (typeInfo is EnumInfo enumType)
                    {
                        CurrentSegments other = current.GetCopy();
                        other.AddName(subSymbol.InstanceName);
                        GenerateEnumGetDataDel(directoryPath, nameSpace, sw, tabCount, subSymbol, enumType, other, parentClassName);
                    }
                    else if (typeInfo is StructInfo structType)
                    {
                        CurrentSegments other = current.GetCopy();
                        other.AddName(subSymbol.InstanceName);
                        GenerateStructGetDataDel(directoryPath, nameSpace, sw, tabCount, subSymbol, structType, other, parentClassName);
                    }
                }
            }
        }

        private void GeneratePrimitiveArrayGetDataDel(string directoryPath, string nameSpace, StreamWriter sw, int tabCount, SymbolInfo subSymbol, PrimitiveInfo primitiveType, CurrentSegments current, int length, string parentClassName, bool isRoot)
        {
            var csharpTypeName = primitiveType.Name.ToCSharpTypeName();
            if (isRoot)
            {
                BeginGet(sw, tabCount);
                sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + $"internal static ref {csharpTypeName}[] Get{current.ToGetName()}(this {parentClassName} parent) => ref parent.ref_{current.ToGetString()};");
                EndGet(sw, tabCount);
            }
            else
            {
                BeginGet(sw, tabCount);
                sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + $"internal static ref {csharpTypeName.CapitalizeFirstLetter()}{length} Get{current.ToGetName()}(this {parentClassName} parent) => ref parent.ref_{current.ToGetString()};");
                EndGet(sw, tabCount);
            }
        }
        private void GenerateStructArrayGetDataDel(string directoryPath, string nameSpace, StreamWriter sw, int tabCount, SymbolInfo symbol, StructInfo structType, CurrentSegments current, int length, string parentClassName, bool isRoot)
        {
            if (isRoot)
            {
                BeginGet(sw, tabCount);
                sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + $"internal static ref {structType.Name.NoWrapperSubffix()}[] Get{current.ToGetName()}(this {parentClassName} parent) => ref parent.ref_{current.ToGetString()};");
                EndGet(sw, tabCount);
            }
            else
            {
                BeginGet(sw, tabCount);
                sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + $"internal static ref {structType.Name.ConvertFieldDefinition()}{length} Get{current.ToGetName()}(this {parentClassName} parent) => ref parent.ref_{current.ToGetString()};");
                EndGet(sw, tabCount);
            }
            for (int i = 0; i < length; i++)
            {
                var currentSymbol = symbol.SubSymbols.ElementAt(i);
                var other = current.GetCopy();
                other.AddIndex(i);

                BeginGet(sw, tabCount);
                sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + $"internal static ref {structType.Name.ConvertFieldDefinition()} Get{other.ToGetName()}(this {parentClassName} parent) => ref parent.ref_{other.ToGetString()};");
                EndGet(sw, tabCount);

                GenerateGet(directoryPath, nameSpace, sw, tabCount, currentSymbol, other, parentClassName, false);
            }
        }

        private void GeneratePrimitiveGetDataDel(string directoryPath, string nameSpace, StreamWriter sw, int tabCount, SymbolInfo subSymbol, PrimitiveInfo primitiveType, CurrentSegments current, string parentClassName)
        {
            var csharpTypeName = primitiveType.Name.ToCSharpTypeName();
            BeginGet(sw, tabCount);
            sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + $"internal static ref {csharpTypeName} Get{current.ToGetName()}(this {parentClassName} parent) => ref parent.ref_{current.ToGetString()};");
            EndGet(sw, tabCount);
        }

        private void GenerateStringGetDataDel(string directoryPath, string nameSpace, StreamWriter sw, int tabCount, SymbolInfo subSymbol, StringInfo stringType, CurrentSegments current, string parentClassName, bool isRoot)
        {
            if (isRoot)
            {

                var csharpTypeName = "string";
                BeginGet(sw, tabCount);
                sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + $"internal static ref {csharpTypeName} Get{current.ToGetName()}(this {parentClassName} parent) => ref parent.ref_{current.ToGetString()};");
                EndGet(sw, tabCount);
            }
            else
            {
                var csharpTypeName = "String";
                BeginGet(sw, tabCount);
                sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + $"internal static ref {csharpTypeName}{stringType.Size} Get{current.ToGetName()}(this {parentClassName} parent) => ref parent.ref_{current.ToGetString()};");
                EndGet(sw, tabCount);
            }
        }

        private void GenerateEnumGetDataDel(string directoryPath, string nameSpace, StreamWriter sw, int tabCount, SymbolInfo subSymbol, EnumInfo enumType, CurrentSegments current, string parentClassName)
        {
            BeginGet(sw, tabCount);
            sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + $"internal static ref {enumType.Name.NoWrapperSubffix()} Get{current.ToGetName()}(this {parentClassName} parent) => ref parent.ref_{current.ToGetString()};");
            EndGet(sw, tabCount);
        }

        private void GenerateStructGetDataDel(string directoryPath, string nameSpace, StreamWriter sw, int tabCount, SymbolInfo symbol, StructInfo structType, CurrentSegments current, string parentClassName)
        {
            BeginGet(sw, tabCount);
            sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + $"internal static ref {structType.Name.ConvertFieldDefinition()} Get{current.ToGetName()}(this {parentClassName} parent) => ref parent.ref_{current.ToGetString()};");
            EndGet(sw, tabCount);
            GenerateGet(directoryPath, nameSpace, sw, tabCount, symbol, current, parentClassName, false);
        }

    }
}