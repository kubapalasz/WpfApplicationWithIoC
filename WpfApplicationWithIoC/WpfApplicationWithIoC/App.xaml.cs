using System.Windows;

namespace WpfApplicationWithIoC
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            IoC.Initialize();

            base.OnStartup(e);
        }
    }
}
