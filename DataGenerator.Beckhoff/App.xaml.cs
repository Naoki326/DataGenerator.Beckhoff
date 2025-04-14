using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Masa.Blazor;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace StructTool
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {

        [STAThread]
        static void Main(string[] args)
        {
            if (CheckMutex())
                return;

            using IHost host = CreateHostBuilder(args).Build();
            host.Start();

            App app = new();
            app.InitializeComponent();

            app.MainWindow = host.Services.GetRequiredService<MainWindow>();
            app.MainWindow.Show();

            app.Run();
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            //BootStrapper bs = new();

            return Host.CreateDefaultBuilder(args)
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureContainer<ContainerBuilder>((context, containerBuilder) =>
                {
                    //bs.ConfigureContainer(containerBuilder);
                })
                .ConfigureAppConfiguration((context, configBuilder) =>
                {
                    configBuilder
                        .SetBasePath(context.HostingEnvironment.ContentRootPath)
                        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
                        .AddJsonFile("appsettings.development.json", optional: true, reloadOnChange: false)
                        .AddEnvironmentVariables()
                        .AddCommandLine(args);
                })
                .ConfigureServices((context, services) =>
                {
                    //// json配置文件
                    //var config = new ConfigCore();
                    //context.Configuration.Bind("CoreConfigs", config);
                    //services.AddSingleton(config);

                    services.AddWpfBlazorWebView();

                    services.AddSingleton(serviceProvider => new MainWindow() { ServiceProvider = serviceProvider });

                    //services.AddCascadingAuthenticationState();
                    //services.AddAuthorizationCore();
                    //services.AddScoped<AuthenticationStateProvider, WholeAuthStateProvider>();
                    services.AddMasaBlazor(options =>
                    {
                        options.Locale = new Locale("zh-CN", "en-US");
                    }).AddI18nForServer("wwwroot/i18n");
                });
        }

        private static Mutex appMutex = default!;
        //判断当前是否双开
        private static bool CheckMutex()
        {
            //禁止双开程序
            appMutex = new Mutex(true, "StructTool", out var createdNew);
            if (!createdNew)
            {
                MessageBox.Show("当前程序不允许双开，请检查原程序是否异常关闭！", "警告", MessageBoxButton.OK, MessageBoxImage.Error);
                var current = Process.GetCurrentProcess();
                foreach (var process in Process.GetProcessesByName(current.ProcessName))
                {
                    if (process.Id != current.Id)
                    {
                        SetForegroundWindow(process.MainWindowHandle);
                        break;
                    }
                }
                Current.Shutdown();
                return true;
            }
            return false;
        }

        [LibraryImport("USER32.DLL")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool SetForegroundWindow(IntPtr hWnd);
    }

}
