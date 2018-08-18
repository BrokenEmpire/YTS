using System.Windows;

namespace YTS.ClientApp
{
    using Views;

    public partial class App : Application
    {
        public App() : base() => MainWindow = new MainWindow_View();

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ShutdownMode = ShutdownMode.OnMainWindowClose;
            MainWindow.Show();
        }
    }
}
