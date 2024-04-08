using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Input;

namespace MauiApp6
{
    public class MyButton : Button
    {
        public readonly static BindableProperty MyCommandProperty = BindableProperty.Create(nameof(MyButton.MyCommand), typeof(ICommand), typeof(MyButton), null);

        public ICommand MyCommand
        {
            get => (ICommand)this.GetValue(MyButton.MyCommandProperty);
            set => this.SetValue(MyButton.MyCommandProperty, value);
        }
    }

    public class MyViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private string foo = "Foo2";
        public string Foo
        {
            get => this.foo;
            set
            {
                this.foo = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Foo)));
            }
        }

        private int count = 1;
        public int Count
        {
            get => this.count;
            set
            {
                this.count = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Count)));
            }
        }

        public ICommand ClickCommand => new Command(() =>
        {
            this.Count++;
        });
    }

    public partial class MainPage : ContentPage
    {
        public MyViewModel ViewModel { get; } = new();

        public MainPage()
        {
            Debug.WriteLine("Foo");
            Debug.WriteLine("Foo");
            Debug.WriteLine("Foo");
            new MauiLib1.Class1();
            InitializeComponent();
        }
    }
}
