using Microsoft.UI.Xaml;
using System;

namespace WinUI3
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
            new MainWindow().Activate();
        }
    }
}
