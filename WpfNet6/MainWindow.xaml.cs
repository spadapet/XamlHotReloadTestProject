using System.Windows;
using System.Windows.Controls;

namespace WpfNet6
{
    public partial class MainWindow : Window
    {
        public MainWindowVM ViewModel { get; } = new MainWindowVM();

#pragma warning disable CA1822 // Mark members as static

        public string Foo => "Foo";
        //public string Bar => "Bar";
        //public string Baz => "Baz";
        //public string Goo => "Goo";

#pragma warning restore CA1822 // Mark members as static

        public MainWindow()
        {
            this.DataContext = this.ViewModel;
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
