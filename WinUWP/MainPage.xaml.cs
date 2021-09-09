using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace WinUWP
{
    public sealed partial class MainPage : Page
    {
        public MainWindowVM ViewModel { get; } = new MainWindowVM();

        public MainPage()
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
