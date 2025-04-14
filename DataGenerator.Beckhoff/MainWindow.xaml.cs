using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DataGenerator.Beckhoff.Shared;
using Microsoft.AspNetCore.Components.WebView.Wpf;

namespace StructTool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            BlazorWebView blazorView = new()
            {
                Name = "blazorView",
                HostPage = "wwwroot\\index.html",
                StartPath = "/home",
                Services = ServiceProvider,
            };
            blazorView.RootComponents.Add(new RootComponent()
            {
                Selector = "#main",
                ComponentType = typeof(Main),
            });

            AddChild(blazorView);
        }

        public IServiceProvider ServiceProvider { get; set; } = default!;
    }
}