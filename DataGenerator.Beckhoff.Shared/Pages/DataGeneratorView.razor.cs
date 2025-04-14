using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using BeckhoffResolver.PLCSymbol;
using BeckhoffResolver.PLCTree;
using Masa.Blazor;
using Microsoft.AspNetCore.Components;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace DataGenerator.Beckhoff.Shared.Pages
{
    public partial class DataGeneratorView
    {

        List<int> initiallyOpen = [];
        BeckhoffResolver.PLCSymbol.SymbolInfo rootSymbol => analyzer.RootSymbol;
        TreeAnalyzer analyzer = new TreeAnalyzer();
        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }

        bool canLoadFromFile = true;
        void LoadFromFile()
        {
            canLoadFromFile = false;
            canResolveFromBeckhoff = false;
            InvokeAsync(StateHasChanged);
            try
            {
                //从json文件中导出倍福数据结构
                analyzer.LoadFromFile();
                directoryPath = analyzer.DirectoryPath;
                nameSpace = analyzer.NameSpace;
                rootFileName = analyzer.RootFileName;
                dllName = analyzer.DllName;
                canGenerate = true;
            }
            finally
            {
                canLoadFromFile = true;
                canResolveFromBeckhoff = true;
                InvokeAsync(StateHasChanged);
            }
        }

        string beckhoffIp = "5.113.195.149.1.1";
        int beckhoffPort = 851;
        bool canResolveFromBeckhoff = true;
        void ResolveFromBeckhoff()
        {
            canLoadFromFile = false;
            canResolveFromBeckhoff = false;
            InvokeAsync(StateHasChanged);
            try
            {
                //连接倍福后，解析倍福数据结构
                analyzer.VisitTree(beckhoffIp, beckhoffPort);
                //数据结构写入json文件
                analyzer.WriteToFile();
                canGenerate = true;
            }
            finally
            {
                canLoadFromFile = true;
                canResolveFromBeckhoff = true;
                InvokeAsync(StateHasChanged);
            }
        }

        internal string directoryPath = "Demo001";
        internal string nameSpace = "PLCManager.Demo001";
        internal string rootFileName = "Demo001Root";
        internal string dllName = "PLCManager.Demo001";

        bool isGenerate = false;
        bool canGenerate = false;
        void GenerateCsFile()
        {
            isGenerate = false;
            canGenerate = false;
            InvokeAsync(StateHasChanged);
            try
            {
                analyzer.DirectoryPath = directoryPath;
                analyzer.NameSpace = nameSpace;
                analyzer.RootFileName = rootFileName;
                analyzer.DllName = dllName;
                if (Directory.Exists(directoryPath))
                {
                    Directory.Delete(directoryPath, true);
                }
                analyzer.GenerateTypes(directoryPath, nameSpace);
                analyzer.GenerateTypeWrappers(directoryPath, nameSpace);
                analyzer.GeneratePLCTree(directoryPath, nameSpace, rootFileName);
                analyzer.WriteToFile();

                DirectoryInfo parentDir = new DirectoryInfo(directoryPath).Parent!;
                string packagePath = @"RoslynPackage";
                if (Directory.Exists(packagePath))
                {
                    isGenerate = GenerateDLL();
                }
                else
                {
                    isGenerate = false;
                }
            }
            finally
            {
                canGenerate = true;
                InvokeAsync(StateHasChanged);
            }
        }

        bool GenerateDLL()
        {
            DirectoryInfo parentDir = new DirectoryInfo(directoryPath).Parent!;
            var syntaxTrees = new List<SyntaxTree>();

            // Get all C# files in the generated code folder
            foreach (var file in Directory.GetFiles(parentDir.FullName, "*.cs", SearchOption.AllDirectories))
            {
                if (file.Contains("obj"))
                    continue;
                var code = File.ReadAllText(file);
                var parseOptions = new CSharpParseOptions(LanguageVersion.Latest);
                var syntaxTree = CSharpSyntaxTree.ParseText(code, parseOptions);
                syntaxTrees.Add(syntaxTree);
            }

            var path = typeof(object).Assembly.Location;
            List<MetadataReference> references =
            [
            ];

            // Load all DLLs from the System.Reactive NuGet package
            string packagePath = @"RoslynPackage";
            foreach (var dllPath in Directory.GetFiles(Path.GetFullPath(packagePath), "*.dll"))
            {
                references.Add(MetadataReference.CreateFromFile(dllPath));
            }

            var compilationOptions = new CSharpCompilationOptions(
                OutputKind.DynamicallyLinkedLibrary,
                platform: Platform.X64, // Set target platform to x64
                allowUnsafe: true // Allow unsafe code blocks
            );

            var compilation = CSharpCompilation.Create(dllName + ".dll")
                .WithOptions(compilationOptions)
                .AddReferences(references)
                .AddSyntaxTrees(syntaxTrees);

            // Step 3: Emit the compiled assembly
            var result = compilation.Emit(dllName + ".dll");
            return result.Success;
        }
    }
}
