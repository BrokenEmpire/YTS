using System.Windows;

namespace YTS.ClientApp
{
    using Views;

    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            ShutdownMode = ShutdownMode.OnMainWindowClose;

            MainWindow = new V_MainWindow();
            MainWindow.Show();
        }
    }
}
