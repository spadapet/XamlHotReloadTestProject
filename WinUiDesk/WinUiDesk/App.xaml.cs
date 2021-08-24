using Microsoft.UI.Xaml;
using System;

namespace WinUiDesk
{
    public partial class App : Application
    {
        private Window window;

        public static Random Random { get; } = new Random();

        public App()
        {
            this.InitializeComponent();
        }

        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            this.window = new MainWindow();
            this.window.Activate();
        }
    }
}
