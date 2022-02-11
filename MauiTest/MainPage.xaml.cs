namespace MauiTest
{
    public partial class MainPage : ContentPage
    {
        public MainVM ViewModel { get; } = new MainVM();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}