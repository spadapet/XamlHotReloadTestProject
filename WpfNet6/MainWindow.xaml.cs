using System.Windows;
using System.Windows.Controls;

namespace WpfNet6
{
    public partial class MainWindow : Window
    {
        public MainWindowVM ViewModel { get; } = new MainWindowVM();

        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void OnTest(object sender, RoutedEventArgs args)
        {
            if (sender is ContentControl cc)
            {
                cc.Content = (cc.Content as string ?? string.Empty) + " 1";
            }
        }

        //private void OnTest2(object sender, RoutedEventArgs args)
        //{
        //    if (sender is ContentControl cc)
        //    {
        //        cc.Content = (cc.Content as string ?? string.Empty) + " 2";
        //    }
        //}
    }
}
