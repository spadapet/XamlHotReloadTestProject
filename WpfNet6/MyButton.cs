using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace WpfNet6
{
    public class MyButton : Button
    {
        public static readonly DependencyProperty Foo1Property = DependencyProperty.Register(
            "Foo1", typeof(string), typeof(MyButton), new PropertyMetadata("Foo1 Default", MyButton.Foo1Changed));

        public string Foo1
        {
            get => (string)this.GetValue(MyButton.Foo1Property);
            set => this.SetValue(MyButton.Foo1Property, value);
        }

        public static void Foo1Changed(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            Debug.Assert(args.Property == MyButton.Foo1Property);
        }

        //public static readonly DependencyProperty Foo2Property = DependencyProperty.Register(
        //    "Foo2", typeof(string), typeof(MyButton), new PropertyMetadata("Foo2 Default", MyButton.Foo2Changed));
        //
        //public string Foo2
        //{
        //    get => (string)this.GetValue(MyButton.Foo2Property);
        //    set => this.SetValue(MyButton.Foo2Property, value);
        //}
        //
        //public static void Foo2Changed(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        //{
        //    Debug.Assert(args.Property == MyButton.Foo2Property);
        //}
    }
}
