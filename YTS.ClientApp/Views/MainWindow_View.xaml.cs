using System;
using System.Windows;

namespace YTS.ClientApp.Views
{
    using ViewModels;

    public partial class MainWindow_View : Window
    {
        public MainWindow_View(MainWindow_ViewModel viewModel = null)
        {
            InitializeComponent();
            DataContext = viewModel ?? new MainWindow_ViewModel();

            Closed += MainWindow_View_Closed;
        }

        private void MainWindow_View_Closed(object sender, EventArgs e)
        {
            Closed -= MainWindow_View_Closed;

            if (DataContext == null)
                return;

            try
            {
                if (DataContext is IDisposable obj)
                {
                    obj.Dispose();
                }
            }
            finally
            {
                DataContext = null;
            }
        }
    }
}
