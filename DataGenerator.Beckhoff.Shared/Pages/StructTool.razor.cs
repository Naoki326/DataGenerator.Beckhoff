using System.Runtime.Loader;
using Microsoft.AspNetCore.Components;
using PlcCore.Data;

namespace DataGenerator.Beckhoff.Shared.Pages
{
    public partial class StructTool
    {

        [Parameter]
        public string DirectoryPath { get; set; } = default!;

        [Parameter]
        public string NameSpace { get; set; } = default!;

        [Parameter]
        public string RootFileName { get; set; } = default!;

        [Parameter]
        public string DllName { get; set; } = default!;

        private IEnumerable<IBaseData> GetLeaf(IBaseData node)
        {
            if (node is null)
            {
                yield break;
            }
            if (!node.Children.Any())
            {
                yield return node;
                yield break;
            }
            foreach (var child in node.Children)
            {
                foreach (var leaf in GetLeaf(child))
                {
                    yield return leaf;
                }
            }
        }

        [Parameter]
        public IPLCRoot Root { get; set; } = default!;

        AssemblyLoadContext? assContext;
        private WeakReference? assWeakRef;
        bool canReLoadRoot = true;
        async Task UnLoadRoot()
        {
            canReLoadRoot = false;
            canConnect = false;
            canDisconnect = false;
            await InvokeAsync(StateHasChanged);
            if(Root is not null)
            {
                Root.StopCircle();
                Root.Dispose();
                Root = null;
            }
            assContext?.Unload();
            if (assWeakRef != null)
            {
                for (int i = 0; assWeakRef.IsAlive && (i < 10); i++)
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }
            }
            assContext = null;
            canReLoadRoot = true;
        }
        async Task ReLoadRoot()
        {
            canReLoadRoot = false;
            canConnect = false;
            canDisconnect = false;
            await InvokeAsync(StateHasChanged);
            await UnLoadRoot();
            //assContext = new AssemblyLoadContext($"StructTool{new Random().Next()}", true);
            string pluginPath = Path.GetFullPath($"{DllName}.dll");
            assContext = new HostAssemblyLoadContext(pluginPath);
            assWeakRef = new WeakReference(assContext, trackResurrection: true);
            try
            {
                var ass = assContext.LoadFromAssemblyPath(pluginPath);
                Type type = ass.GetType($"{NameSpace}.{RootFileName}");
                Root = (IPLCRoot)Activator.CreateInstance(type);
            }
            catch (Exception ee)
            { }
            finally
            {
                canReLoadRoot = true;
                canConnect = true;
                canDisconnect = false;
                await InvokeAsync(StateHasChanged);
            }
        }

        bool canConnect = false;
        bool canDisconnect = false;

        private void Connect()
        {
            canConnect = false;
            canDisconnect = false;
            try
            {
                Root.Connect("5.113.195.149.1.1", 851);
                Root.StartCircle();
                canDisconnect = true;
            }
            catch
            {
                canDisconnect = false;
            }
        }

        private void Disconnect()
        {
            canConnect = false;
            canDisconnect = false;
            try
            {
                Root.StopCircle();
                Root.Disconnect();
                canConnect = true;
            }
            catch
            {
                canConnect = false;
            }
        }

        //IOView
        List<int> initiallyOpen = [];

        protected override Task OnAfterRenderAsync(bool firstRender)
        {
            return base.OnAfterRenderAsync(firstRender);
        }


        private bool disposedValue;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: 释放托管状态(托管对象)
                }

                // TODO: 释放未托管的资源(未托管的对象)并重写终结器
                // TODO: 将大型字段设置为 null
                disposedValue = true;
            }
        }

        // // TODO: 仅当“Dispose(bool disposing)”拥有用于释放未托管资源的代码时才替代终结器
        // ~Home()
        // {
        //     // 不要更改此代码。请将清理代码放入“Dispose(bool disposing)”方法中
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // 不要更改此代码。请将清理代码放入“Dispose(bool disposing)”方法中
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}