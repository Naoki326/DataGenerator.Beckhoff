using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using BeckhoffResolver.PLCStruct;
using BeckhoffResolver.PLCStructModel;

namespace BeckhoffResolver.PLCTree
{
    public partial class TreeAnalyzer
    {

        private void GeneratePLCString(string directoryPath, string nameSpace, StringInfo stringInfo)
        {
            //var itemType = stringInfo.ArrayInnerType!.GetBaseType();
            //string arrItemTypeName = itemType.Name.ConvertFieldDefinition().ToCSharpTypeName().CapitalizeFirstLetter();
            //string arrItemTypeCsName = itemType.Name.ConvertFieldDefinition().ToCSharpTypeName();

            var fileName = Path.Combine(directoryPath, "Struct", ($"String{stringInfo.Size}").MakeValidFileName() + ".cs");
            using FileStream fs = new FileStream(fileName, FileMode.Create);
            using StreamWriter sw = new StreamWriter(fs);

            int tabCount = 0;

            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.Diagnostics;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("using System.Runtime.InteropServices;");
            sw.WriteLine("using System.Runtime.CompilerServices;");
            sw.WriteLine($"using {nameSpace}.Enum;");
            sw.WriteLine("using PlcCore.Data;");
            sw.WriteLine();
            sw.WriteLine($"namespace {nameSpace}.Struct");
            sw.WriteLine("{");
            tabCount++;

            sw.WriteLine(tabCount.GetTabs() + $"/// <summary>");
            sw.WriteLine(tabCount.GetTabs() + $"/// Name from PLC:{stringInfo.Name}");
            sw.WriteLine(tabCount.GetTabs() + $"/// PLCNamespace from PLC: {stringInfo.NameSpace}");
            sw.WriteLine(tabCount.GetTabs() + $"/// Size: {stringInfo.Size}");
            if (stringInfo.TypeAttributes != null && stringInfo.TypeAttributes.Count > 0)
            {
                foreach (var attribute in stringInfo.TypeAttributes)
                {
                    sw.WriteLine(tabCount.GetTabs() + $"/// {attribute.ToAttributeString()}");
                }
            }
            sw.WriteLine(tabCount.GetTabs() + $"/// Comment from PLC: {stringInfo.TypeComment}");
            sw.WriteLine(tabCount.GetTabs() + $"/// <summary>");
            sw.WriteLine(tabCount.GetTabs() + @"[StructLayout(LayoutKind.Explicit)]");

            sw.WriteLine(tabCount.GetTabs() + $"public unsafe struct String{stringInfo.Size} : IPLCStructArray<byte>");
            sw.WriteLine(tabCount.GetTabs() + "{");
            tabCount++;

            GeneratePLCStringField(sw, tabCount, stringInfo);

            tabCount--;
            sw.WriteLine(tabCount.GetTabs() + "}");

            tabCount--;
            sw.WriteLine(tabCount.GetTabs() + "}");
        }

        private void GeneratePLCStringField(StreamWriter sw, int tabCount, StringInfo stringInfo)
        {
            int arrayLength = stringInfo.Size;
            sw.WriteLine(tabCount.GetTabs() + "[FieldOffset(0)]");
            sw.WriteLine(tabCount.GetTabs() + $"public fixed byte Array[{arrayLength}];");
            sw.WriteLine();

            sw.WriteLine(tabCount.GetTabs() + $"public byte this[int index]");
            sw.WriteLine(tabCount.GetTabs() + $"{{");
            tabCount++;
            sw.WriteLine(tabCount.GetTabs() + $"get");
            sw.WriteLine(tabCount.GetTabs() + $"{{");
            tabCount++;
            sw.WriteLine(tabCount.GetTabs() + $"if(index >= Length)");
            sw.WriteLine(tabCount.GetTabs() + $"{{");
            sw.WriteLine((tabCount + 1).GetTabs() + $"throw new IndexOutOfRangeException();");
            sw.WriteLine(tabCount.GetTabs() + $"}}");
            sw.WriteLine(tabCount.GetTabs() + $"fixed(byte* ptr = Array)");
            sw.WriteLine(tabCount.GetTabs() + $"{{");
            sw.WriteLine((tabCount + 1).GetTabs() + $"return ptr[index];");
            sw.WriteLine(tabCount.GetTabs() + $"}}");
            tabCount--;
            sw.WriteLine(tabCount.GetTabs() + $"}}");
            sw.WriteLine(tabCount.GetTabs() + $"set");
            sw.WriteLine(tabCount.GetTabs() + $"{{");
            tabCount++;
            sw.WriteLine(tabCount.GetTabs() + $"if(index >= Length)");
            sw.WriteLine(tabCount.GetTabs() + $"{{");
            sw.WriteLine((tabCount + 1).GetTabs() + $"throw new IndexOutOfRangeException();");
            sw.WriteLine(tabCount.GetTabs() + $"}}");
            sw.WriteLine(tabCount.GetTabs() + $"fixed (byte* ptr = Array)");
            sw.WriteLine(tabCount.GetTabs() + $"{{");
            sw.WriteLine((tabCount + 1).GetTabs() + $"ptr[index] = value;");
            sw.WriteLine(tabCount.GetTabs() + $"}}");
            tabCount--;
            sw.WriteLine(tabCount.GetTabs() + $"}}");
            tabCount--;
            sw.WriteLine(tabCount.GetTabs() + $"}}");
            sw.WriteLine();

            sw.WriteLine(tabCount.GetTabs() + $"private ref byte Get(int index)");
            sw.WriteLine(tabCount.GetTabs() + $"{{");
            tabCount++;
            sw.WriteLine(tabCount.GetTabs() + $"fixed(byte* ptr = Array)");
            sw.WriteLine(tabCount.GetTabs() + $"{{");
            sw.WriteLine((tabCount + 1).GetTabs() + $"return ref ptr[index];");
            sw.WriteLine(tabCount.GetTabs() + $"}}");
            tabCount--;
            sw.WriteLine(tabCount.GetTabs() + $"}}");

            sw.WriteLine(tabCount.GetTabs() + $"public override string ToString()");
            sw.WriteLine(tabCount.GetTabs() + $"{{");
            tabCount++;
            sw.WriteLine(tabCount.GetTabs() + $"fixed (byte* ptr = Array)");
            sw.WriteLine(tabCount.GetTabs() + $"{{");
            sw.WriteLine((tabCount + 1).GetTabs() + $"return Encoding.ASCII.GetString(ptr, 24);");
            sw.WriteLine(tabCount.GetTabs() + $"}}");
            tabCount--;
            sw.WriteLine(tabCount.GetTabs() + $"}}");

            foreach (var i in Enumerable.Range(0, arrayLength))
            {
                sw.WriteLine(tabCount.GetTabs() + "[DebuggerBrowsable(DebuggerBrowsableState.Never)]");
                sw.WriteLine(tabCount.GetTabs() + $"public ref byte Item_{i} => ref Get({i});");
                sw.WriteLine();
            }

            sw.WriteLine(tabCount.GetTabs() + $"public int Length => {arrayLength};");
            sw.WriteLine();

            sw.WriteLine(tabCount.GetTabs() + $"public IEnumerator<byte> GetEnumerator()");
            sw.WriteLine(tabCount.GetTabs() + $"{{");
            tabCount++;
            sw.WriteLine(tabCount.GetTabs() + $"for (int i = 0; i < Length; i++)");
            sw.WriteLine(tabCount.GetTabs() + $"{{");
            tabCount++;
            sw.WriteLine(tabCount.GetTabs() + $"yield return this[i];");
            tabCount--;
            sw.WriteLine(tabCount.GetTabs() + $"}}");
            tabCount--;
            sw.WriteLine(tabCount.GetTabs() + $"}}");
            sw.WriteLine();

            sw.WriteLine(tabCount.GetTabs() + $"IEnumerator IEnumerable.GetEnumerator()");
            sw.WriteLine(tabCount.GetTabs() + $"{{");
            tabCount++;
            sw.WriteLine(tabCount.GetTabs() + $"return this.GetEnumerator();");
            tabCount--;
            sw.WriteLine(tabCount.GetTabs() + $"}}");


            sw.WriteLine(tabCount.GetTabs() + $"public void CopyFrom(ref byte[] sourceData)");
            sw.WriteLine(tabCount.GetTabs() + $"{{");
            tabCount++;
            sw.WriteLine(tabCount.GetTabs() + $"if(sourceData.Length != Length)");
            sw.WriteLine((tabCount + 1).GetTabs() + $"throw new RankException();");
            sw.WriteLine(tabCount.GetTabs() + $"fixed (byte* ptr = sourceData)");
            sw.WriteLine(tabCount.GetTabs() + "{");
            sw.WriteLine((tabCount + 1).GetTabs() + $"Unsafe.CopyBlockUnaligned(ref Unsafe.As<String{arrayLength}, byte>(ref this), ref *(byte*)ptr, (uint)(sizeof(byte) * Length));");
            sw.WriteLine(tabCount.GetTabs() + "}");
            tabCount--;
            sw.WriteLine(tabCount.GetTabs() + $"}}");
            sw.WriteLine();

            sw.WriteLine();
        }

        private void GeneratePLCStructArray(string directoryPath, string nameSpace, ArrayInfo arrayInfo)
        {
            var itemType = arrayInfo.ArrayInnerType!.GetBaseType();
            string arrItemTypeName = itemType.Name.ConvertFieldDefinition().ToCSharpTypeName().CapitalizeFirstLetter();
            string arrItemTypeCsName = itemType.Name.ConvertFieldDefinition().ToCSharpTypeName();

            var fileName = Path.Combine(directoryPath, "Struct", ($"{arrItemTypeName}{arrayInfo.ArrayLength}").MakeValidFileName() + ".cs");
            using FileStream fs = new FileStream(fileName, FileMode.Create);
            using StreamWriter sw = new StreamWriter(fs);

            int tabCount = 0;

            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.Runtime.InteropServices;");
            sw.WriteLine("using System.Runtime.CompilerServices;");
            sw.WriteLine("using System.Diagnostics;");
            sw.WriteLine($"using {nameSpace}.Enum;");
            sw.WriteLine("using PlcCore.Data;");
            sw.WriteLine();
            sw.WriteLine($"namespace {nameSpace}.Struct");
            sw.WriteLine("{");
            tabCount++;

            sw.WriteLine(tabCount.GetTabs() + $"/// <summary>");
            sw.WriteLine(tabCount.GetTabs() + $"/// Name from PLC:{arrayInfo.Name}");
            sw.WriteLine(tabCount.GetTabs() + $"/// PLCNamespace from PLC: {arrayInfo.NameSpace}");
            sw.WriteLine(tabCount.GetTabs() + $"/// Size: {arrayInfo.Size}");
            if (arrayInfo.TypeAttributes != null && arrayInfo.TypeAttributes.Count > 0)
            {
                foreach (var attribute in arrayInfo.TypeAttributes)
                {
                    sw.WriteLine(tabCount.GetTabs() + $"/// {attribute.ToAttributeString()}");
                }
            }
            sw.WriteLine(tabCount.GetTabs() + $"/// Comment from PLC: {arrayInfo.TypeComment}");
            sw.WriteLine(tabCount.GetTabs() + $"/// <summary>");
            sw.WriteLine(tabCount.GetTabs() + @"[StructLayout(LayoutKind.Explicit)]");


            if (itemType.DataType is DataTypeEnum.Primitive)
            {
                GeneratePLCBaseStructArray(sw, tabCount, arrayInfo.ArrayLength, (PrimitiveInfo)itemType);
            }
            else
            {
                GeneratePLCComplexStructArray(sw, tabCount, arrayInfo.ArrayLength, (StructInfo)itemType);
            }

            tabCount--;
            sw.WriteLine(tabCount.GetTabs() + "}");
        }


        private void GeneratePLCBaseStructArray(StreamWriter sw, int tabCount, int arrayLength, PrimitiveInfo itemType)
        {
            string arrItemTypeName = itemType.Name.ConvertFieldDefinition().ToCSharpTypeName().CapitalizeFirstLetter();
            string arrItemTypeCsName = itemType.Name.ConvertFieldDefinition().ToCSharpTypeName();

            sw.WriteLine(tabCount.GetTabs() + $"public unsafe struct {arrItemTypeName}{arrayLength} : IPLCStructArray<{arrItemTypeCsName}>");
            sw.WriteLine(tabCount.GetTabs() + "{");

            tabCount++;

            sw.WriteLine(tabCount.GetTabs() + "[FieldOffset(0)]");
            sw.WriteLine(tabCount.GetTabs() + $"public fixed {arrItemTypeCsName} Array[{arrayLength}];");
            sw.WriteLine();

            sw.WriteLine(tabCount.GetTabs() + $"public {arrItemTypeCsName} this[int index]");
            sw.WriteLine(tabCount.GetTabs() + $"{{");
            tabCount++;
            sw.WriteLine(tabCount.GetTabs() + $"get");
            sw.WriteLine(tabCount.GetTabs() + $"{{");
            tabCount++;
            sw.WriteLine(tabCount.GetTabs() + $"if(index >= Length)");
            sw.WriteLine(tabCount.GetTabs() + $"{{");
            sw.WriteLine((tabCount + 1).GetTabs() + $"throw new IndexOutOfRangeException();");
            sw.WriteLine(tabCount.GetTabs() + $"}}");
            sw.WriteLine(tabCount.GetTabs() + $"fixed({arrItemTypeCsName}* ptr = Array)");
            sw.WriteLine(tabCount.GetTabs() + $"{{");
            sw.WriteLine((tabCount + 1).GetTabs() + $"return ptr[index];");
            sw.WriteLine(tabCount.GetTabs() + $"}}");
            tabCount--;
            sw.WriteLine(tabCount.GetTabs() + $"}}");
            sw.WriteLine(tabCount.GetTabs() + $"set");
            sw.WriteLine(tabCount.GetTabs() + $"{{");
            tabCount++;
            sw.WriteLine(tabCount.GetTabs() + $"if(index >= Length)");
            sw.WriteLine(tabCount.GetTabs() + $"{{");
            sw.WriteLine((tabCount + 1).GetTabs() + $"throw new IndexOutOfRangeException();");
            sw.WriteLine(tabCount.GetTabs() + $"}}");
            sw.WriteLine(tabCount.GetTabs() + $"fixed ({arrItemTypeCsName}* ptr = Array)");
            sw.WriteLine(tabCount.GetTabs() + $"{{");
            sw.WriteLine((tabCount + 1).GetTabs() + $"ptr[index] = value;");
            sw.WriteLine(tabCount.GetTabs() + $"}}");
            tabCount--;
            sw.WriteLine(tabCount.GetTabs() + $"}}");
            tabCount--;
            sw.WriteLine(tabCount.GetTabs() + $"}}");
            sw.WriteLine();

            sw.WriteLine(tabCount.GetTabs() + $"private ref {arrItemTypeCsName} Get(int index)");
            sw.WriteLine(tabCount.GetTabs() + $"{{");
            tabCount++;
            sw.WriteLine(tabCount.GetTabs() + $"fixed({arrItemTypeCsName}* ptr = Array)");
            sw.WriteLine(tabCount.GetTabs() + $"{{");
            sw.WriteLine((tabCount + 1).GetTabs() + $"return ref ptr[index];");
            sw.WriteLine(tabCount.GetTabs() + $"}}");
            tabCount--;
            sw.WriteLine(tabCount.GetTabs() + $"}}");

            foreach (var i in Enumerable.Range(0, arrayLength))
            {
                sw.WriteLine(tabCount.GetTabs() + "[DebuggerBrowsable(DebuggerBrowsableState.Never)]");
                sw.WriteLine(tabCount.GetTabs() + $"public ref {arrItemTypeCsName} Item_{i} => ref Get({i});");
                sw.WriteLine();
            }

            sw.WriteLine(tabCount.GetTabs() + $"public int Length => {arrayLength};");
            sw.WriteLine();

            sw.WriteLine(tabCount.GetTabs() + $"public IEnumerator<{arrItemTypeCsName}> GetEnumerator()");
            sw.WriteLine(tabCount.GetTabs() + $"{{");
            tabCount++;
            sw.WriteLine(tabCount.GetTabs() + $"for (int i = 0; i < Length; i++)");
            sw.WriteLine(tabCount.GetTabs() + $"{{");
            tabCount++;
            sw.WriteLine(tabCount.GetTabs() + $"yield return this[i];");
            tabCount--;
            sw.WriteLine(tabCount.GetTabs() + $"}}");
            tabCount--;
            sw.WriteLine(tabCount.GetTabs() + $"}}");
            sw.WriteLine();

            sw.WriteLine(tabCount.GetTabs() + $"IEnumerator IEnumerable.GetEnumerator()");
            sw.WriteLine(tabCount.GetTabs() + $"{{");
            tabCount++;
            sw.WriteLine(tabCount.GetTabs() + $"return this.GetEnumerator();");
            tabCount--;
            sw.WriteLine(tabCount.GetTabs() + $"}}");
            sw.WriteLine();

            sw.WriteLine(tabCount.GetTabs() + $"public void CopyFrom(ref {arrItemTypeCsName}[] sourceData)");
            sw.WriteLine(tabCount.GetTabs() + $"{{");
            tabCount++;
            sw.WriteLine(tabCount.GetTabs() + $"if(sourceData.Length != Length)");
            sw.WriteLine((tabCount + 1).GetTabs() + $"throw new RankException();");
            sw.WriteLine(tabCount.GetTabs() + $"fixed ({arrItemTypeCsName}* ptr = sourceData)");
            sw.WriteLine(tabCount.GetTabs() + "{");
            sw.WriteLine((tabCount + 1).GetTabs() + $"Unsafe.CopyBlockUnaligned(ref Unsafe.As<{arrItemTypeName}{arrayLength}, byte>(ref this), ref *(byte*)ptr, (uint)(sizeof({arrItemTypeCsName}) * Length));");
            sw.WriteLine(tabCount.GetTabs() + "}");
            tabCount--;
            sw.WriteLine(tabCount.GetTabs() + $"}}");
            sw.WriteLine();

            tabCount--;

            sw.WriteLine(tabCount.GetTabs() + "}");
        }
        private void GeneratePLCComplexStructArray(StreamWriter sw, int tabCount, int arrayLength, StructInfo itemType)
        {
            string arrItemTypeName = itemType.Name.ConvertFieldDefinition().ToCSharpTypeName().CapitalizeFirstLetter();
            string arrItemTypeCsName = itemType.Name.ConvertFieldDefinition().ToCSharpTypeName();

            sw.WriteLine(tabCount.GetTabs() + $"public struct {arrItemTypeName}{arrayLength} : IPLCStructArray<{arrItemTypeCsName}>");
            sw.WriteLine(tabCount.GetTabs() + "{");


            tabCount++;

            foreach (var i in Enumerable.Range(0, arrayLength))
            {
                sw.WriteLine(tabCount.GetTabs() + "[DebuggerBrowsable(DebuggerBrowsableState.Never)]");
                sw.WriteLine(tabCount.GetTabs() + $"[FieldOffset({i * itemType.Size})]");
                sw.WriteLine(tabCount.GetTabs() + $"public {arrItemTypeName} Item_{i};");
                sw.WriteLine();
            }

            sw.WriteLine(tabCount.GetTabs() + $"public {arrItemTypeCsName} this[int index]");
            sw.WriteLine(tabCount.GetTabs() + $"{{");
            tabCount++;
            sw.WriteLine(tabCount.GetTabs() + $"get");
            sw.WriteLine(tabCount.GetTabs() + $"{{");
            tabCount++;
            sw.WriteLine(tabCount.GetTabs() + $"switch(index)");
            sw.WriteLine(tabCount.GetTabs() + $"{{");
            tabCount++;
            foreach (var i in Enumerable.Range(0, arrayLength))
            {
                sw.WriteLine(tabCount.GetTabs() + $"case {i}: return Item_{i};");
            }
            sw.WriteLine(tabCount.GetTabs() + $"default: throw new IndexOutOfRangeException();");
            tabCount--;
            sw.WriteLine(tabCount.GetTabs() + $"}}");
            tabCount--;
            sw.WriteLine(tabCount.GetTabs() + $"}}");
            sw.WriteLine(tabCount.GetTabs() + $"set");
            sw.WriteLine(tabCount.GetTabs() + $"{{");
            tabCount++;
            sw.WriteLine(tabCount.GetTabs() + $"switch(index)");
            sw.WriteLine(tabCount.GetTabs() + $"{{");
            tabCount++;
            foreach (var i in Enumerable.Range(0, arrayLength))
            {
                sw.WriteLine(tabCount.GetTabs() + $"case {i}: Item_{i} = value; break;");
            }
            sw.WriteLine(tabCount.GetTabs() + $"default: throw new IndexOutOfRangeException();");
            tabCount--;
            sw.WriteLine(tabCount.GetTabs() + $"}}");
            tabCount--;
            sw.WriteLine(tabCount.GetTabs() + $"}}");
            sw.WriteLine();

            tabCount--;
            sw.WriteLine(tabCount.GetTabs() + $"}}");
            sw.WriteLine();

            sw.WriteLine(tabCount.GetTabs() + $"public int Length => {arrayLength};");
            sw.WriteLine();

            sw.WriteLine(tabCount.GetTabs() + $"public IEnumerator<{arrItemTypeCsName}> GetEnumerator()");
            sw.WriteLine(tabCount.GetTabs() + $"{{");
            tabCount++;
            sw.WriteLine(tabCount.GetTabs() + $"for (int i = 0; i < Length; i++)");
            sw.WriteLine(tabCount.GetTabs() + $"{{");
            tabCount++;
            sw.WriteLine(tabCount.GetTabs() + $"yield return this[i];");
            tabCount--;
            sw.WriteLine(tabCount.GetTabs() + $"}}");
            tabCount--;
            sw.WriteLine(tabCount.GetTabs() + $"}}");
            sw.WriteLine();

            sw.WriteLine(tabCount.GetTabs() + $"IEnumerator IEnumerable.GetEnumerator()");
            sw.WriteLine(tabCount.GetTabs() + $"{{");
            tabCount++;
            sw.WriteLine(tabCount.GetTabs() + $"return this.GetEnumerator();");
            tabCount--;
            sw.WriteLine(tabCount.GetTabs() + $"}}");
            sw.WriteLine();

            sw.WriteLine(tabCount.GetTabs() + $"public void CopyFrom(ref {arrItemTypeCsName}[] sourceData)");
            sw.WriteLine(tabCount.GetTabs() + $"{{");
            tabCount++;
            sw.WriteLine(tabCount.GetTabs() + $"if(sourceData.Length != Length)");
            sw.WriteLine((tabCount + 1).GetTabs() + $"throw new RankException();");
            sw.WriteLine(tabCount.GetTabs() + $"fixed ({arrItemTypeCsName}* ptr = sourceData)");
            sw.WriteLine(tabCount.GetTabs() + "{");
            sw.WriteLine((tabCount + 1).GetTabs() + $"Unsafe.CopyBlockUnaligned(ref Unsafe.As<{arrItemTypeName}{arrayLength}, byte>(ref this), ref *(byte*)ptr, (uint)(sizeof({arrItemTypeCsName}) * Length));");
            sw.WriteLine(tabCount.GetTabs() + "}");
            tabCount--;
            sw.WriteLine(tabCount.GetTabs() + $"}}");
            sw.WriteLine();

            tabCount--;

            sw.WriteLine(tabCount.GetTabs() + "}");
        }
    }
}
