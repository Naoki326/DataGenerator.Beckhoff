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
using TwinCAT.Ads;

namespace BeckhoffResolver.PLCTree
{
    public partial class TreeAnalyzer
    {
        public void GeneratePLCTree(string directoryPath, string nameSpace, string rootFileName)
        {
            GenerateRootRootClass(directoryPath, nameSpace, rootFileName);

            directoryPath = Path.Combine(directoryPath, "Root");
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            foreach (var subRoot in RootSymbol.GetUsedSubSymbols())
            {
                GenerateRootClass(directoryPath, nameSpace, subRoot);
                GenerateRootClassCtor(directoryPath, nameSpace, subRoot);
                GenerateRootClassGet(directoryPath, nameSpace, subRoot);
            }
        }

        private void GenerateRootRootClass(string directoryPath, string nameSpace, string name)
        {
            var fileName = Path.Combine(directoryPath, $"{name}.cs");

            int tabCount = 0;
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("using System;");
                    sw.WriteLine("using System.Threading;");
                    sw.WriteLine("using System.Collections.Generic;");
                    sw.WriteLine("using System.Runtime.InteropServices;");
                    sw.WriteLine("using TwinCAT.Ads;");
                    sw.WriteLine($"using {nameSpace}.Enum;");
                    sw.WriteLine($"using {nameSpace}.Struct;");
                    sw.WriteLine($"using {nameSpace}.Wrapper;");
                    sw.WriteLine($"using {nameSpace}.Root;");
                    sw.WriteLine($"using PlcCore.Beckhoff;");
                    sw.WriteLine($"using PlcCore.Data;");
                    sw.WriteLine();
                    sw.WriteLine($"namespace {nameSpace}");
                    sw.WriteLine("{");

                    tabCount++;

                    sw.WriteLine("");
                    sw.WriteLine(tabCount.GetTabs() + $"public sealed class {name} : BaseData, IPLCRoot, IBaseData, IDisposable");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    tabCount++;

                    sw.WriteLine("");

                    sw.WriteLine(tabCount.GetTabs() + $"public {name}()");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    tabCount++;

                    sw.WriteLine(tabCount.GetTabs() + "client = new AdsClient();");
                    sw.WriteLine(tabCount.GetTabs() + "");

                    foreach (var subRoot in RootSymbol.GetUsedSubSymbols())
                    {
                        sw.WriteLine(tabCount.GetTabs() + $"{subRoot.InstanceName} = new {subRoot.InstanceName.WrapperSubffix()}(client){{ Name = \"{subRoot.InstanceName}\" }};");
                        sw.WriteLine("");
                    }

                    sw.WriteLine(tabCount.GetTabs() + "this.SetParent();");

                    tabCount--;
                    sw.WriteLine(tabCount.GetTabs() + "}");

                    sw.WriteLine("");
                    sw.WriteLine(tabCount.GetTabs() + "public void Initialize()");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    sw.WriteLine(tabCount.GetTabs() + "    this.SetInit();");
                    sw.WriteLine(tabCount.GetTabs() + "}");
                    sw.WriteLine("");

                    foreach (var subRoot in RootSymbol.GetUsedSubSymbols())
                    {
                        sw.WriteLine(tabCount.GetTabs() + $"public {subRoot.InstanceName.WrapperSubffix()} {subRoot.InstanceName} {{ get; init; }}");
                        sw.WriteLine("");
                    }

                    sw.WriteLine(tabCount.GetTabs() + "internal override void Init()");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    sw.WriteLine(tabCount.GetTabs() + "}");
                    sw.WriteLine();

                    sw.WriteLine(tabCount.GetTabs() + "private CircleManager circleManager = new CircleManager();");
                    sw.WriteLine(tabCount.GetTabs() + "");
                    sw.WriteLine(tabCount.GetTabs() + "public void AddToNotifyCircle(IBaseData node)");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    sw.WriteLine(tabCount.GetTabs() + "    circleManager.AddCircleCallback(node);");
                    sw.WriteLine(tabCount.GetTabs() + "}");
                    sw.WriteLine(tabCount.GetTabs() + "");
                    sw.WriteLine(tabCount.GetTabs() + "public void AddToNotifyCircles(IEnumerable<IBaseData> nodes)");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    sw.WriteLine(tabCount.GetTabs() + "    circleManager.AddCircleCallbacks(nodes);");
                    sw.WriteLine(tabCount.GetTabs() + "}");
                    sw.WriteLine(tabCount.GetTabs() + "");
                    sw.WriteLine(tabCount.GetTabs() + "public void StartCircle()");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    sw.WriteLine(tabCount.GetTabs() + "	circleManager.StartCircle();");
                    sw.WriteLine(tabCount.GetTabs() + "}");
                    sw.WriteLine(tabCount.GetTabs() + "");
                    sw.WriteLine(tabCount.GetTabs() + "public void StopCircle()");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    sw.WriteLine(tabCount.GetTabs() + "	circleManager.StopCircle();");
                    sw.WriteLine(tabCount.GetTabs() + "}");
                    sw.WriteLine(tabCount.GetTabs() + "");
                    sw.WriteLine(tabCount.GetTabs() + "public void SetInterval(int interval)");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    sw.WriteLine(tabCount.GetTabs() + "	circleManager.ReadCircleSleepTime = interval;");
                    sw.WriteLine(tabCount.GetTabs() + "	circleManager.ReadSleepTime = interval;");
                    sw.WriteLine(tabCount.GetTabs() + "}");

                    sw.WriteLine();
                    sw.WriteLine(tabCount.GetTabs() + "public override void CheckAndNotify(int timeout = -1, CancellationToken token = default)");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    sw.WriteLine(tabCount.GetTabs() + "    foreach (var child in Children)");
                    sw.WriteLine(tabCount.GetTabs() + "    {");
                    sw.WriteLine(tabCount.GetTabs() + "        child?.CheckAndNotify(timeout, token);");
                    sw.WriteLine(tabCount.GetTabs() + "    }");
                    sw.WriteLine(tabCount.GetTabs() + "}");
                    sw.WriteLine();

                    sw.WriteLine(tabCount.GetTabs() + "public override IEnumerable<IBaseData> Children");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    tabCount++;
                    sw.WriteLine(tabCount.GetTabs() + "get");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    tabCount++;
                    foreach (var subRoot in RootSymbol.GetUsedSubSymbols())
                    {
                        sw.WriteLine(tabCount.GetTabs() + $"yield return {subRoot.InstanceName};");
                    }
                    tabCount--;
                    sw.WriteLine(tabCount.GetTabs() + "}");
                    tabCount--;
                    sw.WriteLine(tabCount.GetTabs() + "}");
                    sw.WriteLine();

                    sw.WriteLine(tabCount.GetTabs() + "public override IBaseData Get(string name)");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    tabCount++;
                    sw.WriteLine(tabCount.GetTabs() + "switch (name)");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    tabCount++;
                    foreach (var subRoot in RootSymbol.GetUsedSubSymbols())
                    {
                        sw.WriteLine(tabCount.GetTabs() + $"case nameof({subRoot.InstanceName}):");
                        sw.WriteLine((tabCount + 1).GetTabs() + $"return {subRoot.InstanceName};");
                    }
                    tabCount--;
                    sw.WriteLine(tabCount.GetTabs() + "}");
                    sw.WriteLine(tabCount.GetTabs() + $"throw new KeyNotFoundException(name);");
                    tabCount--;
                    sw.WriteLine(tabCount.GetTabs() + "}");

                    sw.WriteLine(tabCount.GetTabs() + "public void Connect(string ip, int port)");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    sw.WriteLine(tabCount.GetTabs() + "    client.Connect(ip, port);");
                    sw.WriteLine(tabCount.GetTabs() + "}");
                    sw.WriteLine(tabCount.GetTabs() + "");
                    sw.WriteLine(tabCount.GetTabs() + "public bool TryConnect(string ip, int port)");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    sw.WriteLine(tabCount.GetTabs() + "    try");
                    sw.WriteLine(tabCount.GetTabs() + "    {");
                    sw.WriteLine(tabCount.GetTabs() + "        Connect(ip, port);");
                    sw.WriteLine(tabCount.GetTabs() + "        return true;");
                    sw.WriteLine(tabCount.GetTabs() + "    }");
                    sw.WriteLine(tabCount.GetTabs() + "    catch (Exception ex)");
                    sw.WriteLine(tabCount.GetTabs() + "    {");
                    sw.WriteLine(tabCount.GetTabs() + "        return false;");
                    sw.WriteLine(tabCount.GetTabs() + "    }");
                    sw.WriteLine(tabCount.GetTabs() + "}");
                    sw.WriteLine(tabCount.GetTabs() + "");
                    sw.WriteLine(tabCount.GetTabs() + "public void Disconnect()");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    sw.WriteLine(tabCount.GetTabs() + "    client.Disconnect();");
                    sw.WriteLine(tabCount.GetTabs() + "}");
                    sw.WriteLine(tabCount.GetTabs() + "");
                    sw.WriteLine(tabCount.GetTabs() + "public bool TryDisconnect()");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    sw.WriteLine(tabCount.GetTabs() + "    try");
                    sw.WriteLine(tabCount.GetTabs() + "    {");
                    sw.WriteLine(tabCount.GetTabs() + "        Disconnect();");
                    sw.WriteLine(tabCount.GetTabs() + "        return true;");
                    sw.WriteLine(tabCount.GetTabs() + "    }");
                    sw.WriteLine(tabCount.GetTabs() + "    catch (Exception ex)");
                    sw.WriteLine(tabCount.GetTabs() + "    {");
                    sw.WriteLine(tabCount.GetTabs() + "        return false;");
                    sw.WriteLine(tabCount.GetTabs() + "    }");
                    sw.WriteLine(tabCount.GetTabs() + "}");
                    sw.WriteLine(tabCount.GetTabs() + "");
                    sw.WriteLine(tabCount.GetTabs() + "private AdsClient client;");
                    sw.WriteLine(tabCount.GetTabs() + "");
                    sw.WriteLine(tabCount.GetTabs() + "private bool disposedValue;");
                    sw.WriteLine(tabCount.GetTabs() + "");
                    sw.WriteLine(tabCount.GetTabs() + "private void Dispose(bool disposing)");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    sw.WriteLine(tabCount.GetTabs() + "    if (!disposedValue)");
                    sw.WriteLine(tabCount.GetTabs() + "    {");
                    sw.WriteLine(tabCount.GetTabs() + "        if (disposing)");
                    sw.WriteLine(tabCount.GetTabs() + "        {");
                    sw.WriteLine(tabCount.GetTabs() + "            // TODO: 释放托管状态(托管对象)");
                    sw.WriteLine(tabCount.GetTabs() + "        }");
                    sw.WriteLine(tabCount.GetTabs() + "");
                    sw.WriteLine(tabCount.GetTabs() + "        // TODO: 释放未托管的资源(未托管的对象)并重写终结器");
                    sw.WriteLine(tabCount.GetTabs() + "        client.Dispose();");
                    sw.WriteLine(tabCount.GetTabs() + "        // TODO: 将大型字段设置为 null");
                    sw.WriteLine(tabCount.GetTabs() + "        disposedValue = true;");
                    sw.WriteLine(tabCount.GetTabs() + "    }");
                    sw.WriteLine(tabCount.GetTabs() + "}");
                    sw.WriteLine(tabCount.GetTabs() + "");
                    sw.WriteLine(tabCount.GetTabs() + "// TODO: 仅当“Dispose(bool disposing)”拥有用于释放未托管资源的代码时才替代终结器");
                    sw.WriteLine(tabCount.GetTabs() + $"~{name}()");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    sw.WriteLine(tabCount.GetTabs() + "    // 不要更改此代码。请将清理代码放入“Dispose(bool disposing)”方法中");
                    sw.WriteLine(tabCount.GetTabs() + "    Dispose(disposing: false);");
                    sw.WriteLine(tabCount.GetTabs() + "}");
                    sw.WriteLine(tabCount.GetTabs() + "");
                    sw.WriteLine(tabCount.GetTabs() + "public override void Dispose()");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    sw.WriteLine(tabCount.GetTabs() + "    // 不要更改此代码。请将清理代码放入“Dispose(bool disposing)”方法中");
                    sw.WriteLine(tabCount.GetTabs() + "    Dispose(disposing: true);");
                    sw.WriteLine(tabCount.GetTabs() + "    GC.SuppressFinalize(this);");
                    sw.WriteLine(tabCount.GetTabs() + "}");

                    tabCount--;

                    sw.WriteLine("");
                    sw.WriteLine("}");

                    tabCount--;
                    sw.WriteLine(tabCount.GetTabs() + "}");

                    sw.WriteLine("");
                }
            }
        }

        private void GenerateRootClassCtor(string directoryPath, string nameSpace, SymbolInfo subRoot)
        {
            var fileName = Path.Combine(directoryPath, $"{subRoot.InstanceName.WrapperSubffix()}_ctor.cs");

            int tabCount = 0;
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("using System;");
                    sw.WriteLine("using System.Collections.Generic;");
                    sw.WriteLine("using System.Runtime.InteropServices;");
                    sw.WriteLine("using TwinCAT.Ads;");
                    sw.WriteLine($"using {nameSpace}.Enum;");
                    sw.WriteLine($"using {nameSpace}.Struct;");
                    sw.WriteLine($"using {nameSpace}.Wrapper;");
                    sw.WriteLine($"using PlcCore.Beckhoff;");
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
                    sw.WriteLine(tabCount.GetTabs() + $"public sealed partial class {subRoot.InstanceName.WrapperSubffix()} : BaseData, IBaseData");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    tabCount++;

                    sw.WriteLine(tabCount.GetTabs() + "public override IEnumerable<IBaseData> Children");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    tabCount++;
                    sw.WriteLine(tabCount.GetTabs() + "get");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    tabCount++;
                    foreach (var subS in subRoot.GetUsedSubSymbols())
                    {
                        if (subS.IsArray)
                        {
                            var typeInfo = TypeDict[subS.TypeNameFromPLC].GetBaseType();
                            var itemInfo = ((ArrayInfo)typeInfo).ArrayInnerType!.GetBaseType();
                            var length = ((ArrayInfo)typeInfo).ArrayLength;
                            if (itemInfo is PrimitiveInfo primitiveType)
                            {
                                sw.WriteLine(tabCount.GetTabs() + $"yield return {subS.InstanceName};");
                            }
                            else if (typeInfo is StringInfo stringType)
                            {
                                sw.WriteLine(tabCount.GetTabs() + $"yield return {subS.InstanceName};");
                            }
                            else if (typeInfo is EnumInfo enumType)
                            {
                                sw.WriteLine(tabCount.GetTabs() + $"yield return {subS.InstanceName};");
                            }
                            else if (itemInfo is StructInfo structType)
                            {
                                sw.WriteLine(tabCount.GetTabs() + $"yield return {subS.InstanceName};");
                            }
                        }
                        else
                        {
                            var typeInfo = TypeDict[subS.TypeNameFromPLC].GetBaseType();
                            if (typeInfo is PrimitiveInfo primitiveType)
                            {
                                sw.WriteLine(tabCount.GetTabs() + $"yield return {subS.InstanceName};");
                            }
                            else if (typeInfo is StringInfo stringType)
                            {
                                sw.WriteLine(tabCount.GetTabs() + $"yield return {subS.InstanceName};");
                            }
                            else if (typeInfo is EnumInfo enumType)
                            {
                                sw.WriteLine(tabCount.GetTabs() + $"yield return {subS.InstanceName};");
                            }
                            else if (typeInfo is StructInfo structType)
                            {
                                sw.WriteLine(tabCount.GetTabs() + $"yield return {subS.InstanceName};");
                            }
                        }
                    }
                    tabCount--;
                    sw.WriteLine(tabCount.GetTabs() + "}");
                    tabCount--;
                    sw.WriteLine(tabCount.GetTabs() + "}");
                    sw.WriteLine();

                    sw.WriteLine(tabCount.GetTabs() + "public override IBaseData Get(string name)");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    tabCount++;
                    sw.WriteLine(tabCount.GetTabs() + "switch (name)");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    tabCount++;
                    foreach (var subS in subRoot.GetUsedSubSymbols())
                    {
                        sw.WriteLine(tabCount.GetTabs() + $"case nameof({subS.InstanceName}):");
                        sw.WriteLine((tabCount + 1).GetTabs() + $"return {subS.InstanceName};");
                    }
                    tabCount--;
                    sw.WriteLine(tabCount.GetTabs() + "}");
                    sw.WriteLine(tabCount.GetTabs() + $"throw new KeyNotFoundException(name);");
                    tabCount--;
                    sw.WriteLine(tabCount.GetTabs() + "}");

                    sw.WriteLine();
                    sw.WriteLine(tabCount.GetTabs() + $"private readonly AdsClient client;");
                    sw.WriteLine();

                    sw.WriteLine(tabCount.GetTabs() + $"public {subRoot.InstanceName.WrapperSubffix()}(AdsClient client)");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    tabCount++;

                    sw.WriteLine(tabCount.GetTabs() + "this.client = client;");
                    sw.WriteLine();

                    GenerateCtor(directoryPath, nameSpace, sw, tabCount, subRoot, new CurrentSegments(), true);

                    tabCount--;
                    sw.WriteLine(tabCount.GetTabs() + "}");

                    sw.WriteLine("");


                    sw.WriteLine(tabCount.GetTabs() + "private bool disposedValue;");
                    sw.WriteLine(tabCount.GetTabs() + "");
                    sw.WriteLine(tabCount.GetTabs() + "private void Dispose(bool disposing)");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    sw.WriteLine(tabCount.GetTabs() + "    if (!disposedValue)");
                    sw.WriteLine(tabCount.GetTabs() + "    {");
                    sw.WriteLine(tabCount.GetTabs() + "        if (disposing)");
                    sw.WriteLine(tabCount.GetTabs() + "        {");
                    sw.WriteLine(tabCount.GetTabs() + "            // TODO: 释放托管状态(托管对象)");
                    sw.WriteLine(tabCount.GetTabs() + "        }");
                    sw.WriteLine(tabCount.GetTabs() + "");
                    sw.WriteLine(tabCount.GetTabs() + "        // TODO: 释放未托管的资源(未托管的对象)并重写终结器");
                    sw.WriteLine(tabCount.GetTabs() + "        // TODO: 将大型字段设置为 null");
                    sw.WriteLine(tabCount.GetTabs() + "        disposedValue = true;");
                    sw.WriteLine(tabCount.GetTabs() + "    }");
                    sw.WriteLine(tabCount.GetTabs() + "}");
                    sw.WriteLine(tabCount.GetTabs() + "");
                    sw.WriteLine(tabCount.GetTabs() + "// TODO: 仅当“Dispose(bool disposing)”拥有用于释放未托管资源的代码时才替代终结器");
                    sw.WriteLine(tabCount.GetTabs() + $"~{subRoot.InstanceName.WrapperSubffix()}()");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    sw.WriteLine(tabCount.GetTabs() + "    // 不要更改此代码。请将清理代码放入“Dispose(bool disposing)”方法中");
                    sw.WriteLine(tabCount.GetTabs() + "    Dispose(disposing: false);");
                    sw.WriteLine(tabCount.GetTabs() + "}");
                    sw.WriteLine(tabCount.GetTabs() + "");
                    sw.WriteLine(tabCount.GetTabs() + "public override void Dispose()");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    sw.WriteLine(tabCount.GetTabs() + "    // 不要更改此代码。请将清理代码放入“Dispose(bool disposing)”方法中");
                    sw.WriteLine(tabCount.GetTabs() + "    Dispose(disposing: true);");
                    sw.WriteLine(tabCount.GetTabs() + "    GC.SuppressFinalize(this);");
                    sw.WriteLine(tabCount.GetTabs() + "}");



                    tabCount--;
                    sw.WriteLine(tabCount.GetTabs() + "}");



                    tabCount--;

                    sw.WriteLine("");
                    sw.WriteLine("}");
                }
            }
        }

        private void GenerateRootClassGet(string directoryPath, string nameSpace, SymbolInfo subRoot)
        {
            var fileName = Path.Combine(directoryPath, $"{subRoot.InstanceName.WrapperSubffix()}_get.cs");

            int tabCount = 0;
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("using System;");
                    sw.WriteLine("using System.Collections.Generic;");
                    sw.WriteLine("using System.Runtime.InteropServices;");
                    sw.WriteLine("using TwinCAT.Ads;");
                    sw.WriteLine($"using {nameSpace}.Enum;");
                    sw.WriteLine($"using {nameSpace}.Struct;");
                    sw.WriteLine($"using {nameSpace}.Wrapper;");
                    sw.WriteLine($"using PlcCore.Beckhoff;");
                    sw.WriteLine($"using PlcCore.Data;");
                    sw.WriteLine();
                    sw.WriteLine($"namespace {nameSpace}.Root");
                    sw.WriteLine("{");

                    tabCount++;


                    sw.WriteLine(tabCount.GetTabs() + "");
                    sw.WriteLine(tabCount.GetTabs() + $"internal static class GetClass_{Guid.NewGuid():N}");
                    sw.WriteLine(tabCount.GetTabs() + "{");
                    tabCount++;
                    GenerateGet(directoryPath, nameSpace, sw, tabCount, subRoot, new CurrentSegments(), subRoot.InstanceName.WrapperSubffix());
                    tabCount--;
                    sw.WriteLine(tabCount.GetTabs() + "}");

                    //tabCount--;

                    sw.WriteLine("");
                    sw.WriteLine("}");
                }
            }
        }

        private void GenerateCtor(string directoryPath, string nameSpace,
            StreamWriter sw, int tabCount,
            SymbolInfo symbol, CurrentSegments currentName, bool isRoot)
        {
            string endMark = isRoot ? ";" : ",";
            foreach (var subSymbol in symbol.GetUsedSubSymbols())
            {
                CurrentSegments other = currentName.GetCopy();
                other.AddName(subSymbol.InstanceName);
                if (subSymbol.IsArray)
                {
                    var typeInfo = TypeDict[subSymbol.TypeNameFromPLC].GetBaseType();
                    var itemInfo = ((ArrayInfo)typeInfo).ArrayInnerType!.GetBaseType();
                    var length = ((ArrayInfo)typeInfo).ArrayLength;
                    bool isStartFromZero = ((ArrayInfo)typeInfo).IsStartFromZero;
                    string isStartFromZeroStr = ((ArrayInfo)typeInfo).IsStartFromZero ? "true" : "false";
                    if (itemInfo is PrimitiveInfo primitiveType)
                    {
                        var csharpTypeName = primitiveType.Name.ToCSharpTypeName();

                        sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) +
                            $"{subSymbol.InstanceName} = new Beckhoff{csharpTypeName.CapitalizeFirstLetter()}Array<{csharpTypeName.CapitalizeFirstLetter()}{length}>(this.Get{other.ToGetName()}, client, {subSymbol.IndexGroup}, {subSymbol.IndexOffset},");
                        //subSymbol.SubSymbols.
                        sw.Write(ClassDefineHelper.GetTabs(tabCount + 1) + "new uint[] { ");
                        foreach (var s in subSymbol.GetUsedSubSymbols())
                        {
                            sw.Write(s.IndexGroup + " ,");
                        }
                        sw.Write(" },\r\n");
                        sw.Write(ClassDefineHelper.GetTabs(tabCount + 1) + "new uint[] { ");
                        foreach (var s in subSymbol.GetUsedSubSymbols())
                        {
                            sw.Write(s.IndexOffset + " ,");
                        }
                        sw.Write($" }}, {isStartFromZeroStr}){{ Name = \"{subSymbol.InstanceName}\" }}{endMark}\r\n");
                    }
                    else if (typeInfo is StringInfo stringType)
                    {
                        sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) +
                            $"{subSymbol.InstanceName} = new BeckhoffStringArray(this.Get{other.ToGetName()}, client, {subSymbol.IndexGroup}, {subSymbol.IndexOffset},");
                        //subSymbol.SubSymbols.
                        sw.Write(ClassDefineHelper.GetTabs(tabCount + 1) + "new uint[] { ");
                        foreach (var s in subSymbol.GetUsedSubSymbols())
                        {
                            sw.Write(s.IndexGroup + " ,");
                        }
                        sw.Write(" },\r\n");
                        sw.Write(ClassDefineHelper.GetTabs(tabCount + 1) + "new uint[] { ");
                        foreach (var s in subSymbol.GetUsedSubSymbols())
                        {
                            sw.Write(s.IndexOffset + " ,");
                        }
                        sw.Write($" }}, {isStartFromZeroStr}){{ Name = \"{subSymbol.InstanceName}\" }}{endMark}\r\n");
                    }
                    else if (typeInfo is EnumInfo enumType)
                    {
                        if (isRoot)
                        {
                            sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) +
                                $"{subSymbol.InstanceName} = new BeckhoffEnumArray(this.Get{other.ToGetName()}, client, {subSymbol.IndexGroup}, {subSymbol.IndexOffset},");
                        }
                        else
                        {
                            sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) +
                                $"{subSymbol.InstanceName} = new BeckhoffEnumArray<{enumType.Name.NoWrapperSubffix()}>(this.Get{other.ToGetName()}, client, {subSymbol.IndexGroup}, {subSymbol.IndexOffset},");
                        }
                        //subSymbol.SubSymbols.
                        sw.Write(ClassDefineHelper.GetTabs(tabCount + 1) + "new uint[] { ");
                        foreach (var s in subSymbol.GetUsedSubSymbols())
                        {
                            sw.Write(s.IndexGroup + " ,");
                        }
                        sw.Write(" },\r\n");
                        sw.Write(ClassDefineHelper.GetTabs(tabCount + 1) + "new uint[] { ");
                        foreach (var s in subSymbol.GetUsedSubSymbols())
                        {
                            sw.Write(s.IndexOffset + " ,");
                        }
                        sw.Write($" }}, {isStartFromZeroStr}){{ Name = \"{subSymbol.InstanceName}\" }}{endMark}\r\n");
                    }
                    else if (itemInfo is StructInfo structType)
                    {
                        sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) +
                            $"{subSymbol.InstanceName} = new BeckhoffStructArray<{structType.Name.NoWrapperSubffix()}{length}, {structType.Name.WrapperSubffix()}, {structType.Name.ConvertFieldDefinition()}>(this.Get{other.ToGetName()}, client, {subSymbol.IndexGroup}, {subSymbol.IndexOffset},");
                        sw.Write(ClassDefineHelper.GetTabs(tabCount + 1) + "new uint[] { ");
                        foreach (var s in subSymbol.GetUsedSubSymbols())
                        {
                            sw.Write(s.IndexGroup + " ,");
                        }
                        sw.Write(" },\r\n");
                        sw.Write(ClassDefineHelper.GetTabs(tabCount + 1) + "new uint[] { ");
                        foreach (var s in subSymbol.GetUsedSubSymbols())
                        {
                            sw.Write(s.IndexOffset + " ,");
                        }
                        sw.Write($" }},\r\n");
                        tabCount++;

                        sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + $"new {structType.Name.WrapperSubffix()}[]");
                        sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + $"{{");

                        tabCount++;
                        for (int i = 0; i < length; i++)
                        {
                            var subInfo = subSymbol.SubSymbols.ElementAt(i);

                            var other2 = other.GetCopy();
                            other2.AddIndex(i);

                            sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + $"new {structType.Name.WrapperSubffix()}(this.Get{other2.ToGetName()}, client, {subInfo.IndexGroup}, {subInfo.IndexOffset})");
                            sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + $"{{");

                            tabCount++;
                            sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + $" Name = \"Item_{(isStartFromZero ? i : i + 1)}\",");
                            GenerateCtor(directoryPath, nameSpace, sw, tabCount, subInfo, other2, false);

                            tabCount--;

                            sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + $"}},");
                        }

                        tabCount--;

                        tabCount--;
                        sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + $"}}, {isStartFromZeroStr}){{ Name = \"{subSymbol.InstanceName}\" }}{endMark}");
                    }
                }
                else
                {
                    var typeInfo = TypeDict[subSymbol.TypeNameFromPLC].GetBaseType();
                    if (typeInfo is PrimitiveInfo primitiveType)
                    {
                        var csharpTypeName = primitiveType.Name.ToCSharpTypeName();
                        sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + $"{subSymbol.InstanceName} = new Beckhoff{csharpTypeName.CapitalizeFirstLetter()}(this.Get{other.ToGetName()}, client, {subSymbol.IndexGroup}, {subSymbol.IndexOffset}){{ Name = \"{subSymbol.InstanceName}\" }}{endMark}");
                    }
                    else if (typeInfo is EnumInfo enumType)
                    {
                        sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + $"{subSymbol.InstanceName} = new BeckhoffEnum<{enumType.Name.NoWrapperSubffix()}>(this.Get{other.ToGetName()}, client, {subSymbol.IndexGroup}, {subSymbol.IndexOffset}){{ Name = \"{subSymbol.InstanceName}\" }}{endMark}");
                    }
                    else if (typeInfo is StringInfo stringType)
                    {
                        sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + $"{subSymbol.InstanceName} = new BeckhoffString<String{typeInfo.Size}>(this.Get{other.ToGetName()}, client, {subSymbol.IndexGroup}, {subSymbol.IndexOffset}){{ Name = \"{subSymbol.InstanceName}\" }}{endMark}");
                    }
                    else if (typeInfo is StructInfo structType)
                    {
                        sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + $"{subSymbol.InstanceName} = new {structType.Name.WrapperSubffix()}(this.Get{other.ToGetName()}, client, {subSymbol.IndexGroup}, {subSymbol.IndexOffset})");
                        sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + @"{");
                        tabCount++;

                        sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + $"Name = \"{subSymbol.InstanceName}\",");
                        GenerateCtor(directoryPath, nameSpace, sw, tabCount, subSymbol, other, false);

                        tabCount--;
                        sw.WriteLine(ClassDefineHelper.GetTabs(tabCount) + $"}}{endMark}");
                    }
                }
            }
        }



    }
}