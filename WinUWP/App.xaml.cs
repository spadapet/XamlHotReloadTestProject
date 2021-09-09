using Microsoft.UI.Xaml;
using System;

namespace WinUWP
{
    sealed partial class App : Application
    {
        public static Random Random { get; } = new Random();

        public App()
        {
            this.InitializeComponent();
        }

        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            if (Window.Current.Content == null)
            {
                Window.Current.Content = new MainPage();
            }

            Window.Current.Activate();
        }
    }
}
