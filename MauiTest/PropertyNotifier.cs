using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiTest
{
    public abstract class PropertyNotifier : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertiesChanged()
        {
            this.OnPropertyChanged(null);
        }

        protected void OnPropertyChanged(string name)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        protected bool SetProperty<T>(ref T property, T value, [CallerMemberName] string name = null)
        {
            if (EqualityComparer<T>.Default.Equals(property, value))
            {
                return false;
            }

            property = value;

            if (name != null)
            {
                this.OnPropertyChanged(name);
            }

            return true;
        }
    }
}
