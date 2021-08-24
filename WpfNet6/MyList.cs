using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Controls;

namespace WpfNet6
{
    public class StringsTypeConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(string);
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return destinationType == typeof(string);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string values)
            {
                List<string> strings = new List<string>();
                foreach (string str in values.Split(','))
                {
                    strings.Add(str.Trim());
                }

                return strings;
            }

            return base.ConvertFrom(context, culture, value);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (value is List<string> strings && destinationType == typeof(string))
            {
                return string.Join(",", strings);
            }

            return base.ConvertTo(context, culture, value, destinationType);
        }
    }

    public class MyList : ListBox, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private List<string> strings = new List<string>(1000);

        [TypeConverter(typeof(StringsTypeConverter))]
        public List<string> Strings
        {
            get => this.strings;
            set
            {
                if (value != null && value != this.strings)
                {
                    this.strings = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Strings)));
                }
            }
        }

        public MyList()
        {
            for (int i = 0; i < 1000; i++)
            {
                this.strings.Add($"String {i + 1}");
            }

            this.Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, System.Windows.RoutedEventArgs e)
        {
            this.Loaded -= OnLoaded;
            this.ItemsSource = this.Strings;
        }
    }
}
