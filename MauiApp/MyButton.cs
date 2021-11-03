using System.Diagnostics;
using Microsoft.Maui.Controls;

namespace MauiApp5
{
    public class MyButton : Button
    {
        public static readonly BindableProperty Foo1Property = BindableProperty.Create(
            "Foo1", typeof(string), typeof(MyButton), "Foo1 Default", propertyChanged: MyButton.Foo1Changed);

        public string Foo1
        {
            get => (string)this.GetValue(MyButton.Foo1Property);
            set => this.SetValue(MyButton.Foo1Property, value);
        }

        public static void Foo1Changed(BindableObject bindable, object oldValue, object newValue)
        {
            Debug.Assert(bindable is MyButton);
        }

        //public static readonly BindableProperty Foo2Property = BindableProperty.Create(
        //    "Foo2", typeof(string), typeof(MyButton), "Foo2 Default", propertyChanged: MyButton.Foo2Changed);
        //
        //public string Foo2
        //{
        //    get => (string)this.GetValue(MyButton.Foo2Property);
        //    set => this.SetValue(MyButton.Foo2Property, value);
        //}
        //
        //public static void Foo2Changed(BindableObject bindable, object oldValue, object newValue)
        //{
        //    Debug.Assert(bindable is MyButton);
        //}
    }
}
