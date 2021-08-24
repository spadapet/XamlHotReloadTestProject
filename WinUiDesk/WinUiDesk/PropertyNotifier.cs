namespace WinUiDesk
{
    public abstract class PropertyNotifier : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {
        private event System.ComponentModel.PropertyChangingEventHandler propertyChanging;
        private event System.ComponentModel.PropertyChangedEventHandler propertyChanged;

        protected void OnPropertiesChanging()
        {
            this.OnPropertyChanging(null);
        }

        protected void OnPropertiesChanged()
        {
            this.OnPropertyChanged(null);
        }

        protected void OnPropertyChanging(string name)
        {
            this.propertyChanging?.Invoke(this, new System.ComponentModel.PropertyChangingEventArgs(name));
        }

        protected void OnPropertyChanged(string name)
        {
            this.propertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(name));
        }

        protected bool SetProperty<T>(ref T property, T value, [System.Runtime.CompilerServices.CallerMemberName] string name = null)
        {
            if (System.Collections.Generic.EqualityComparer<T>.Default.Equals(property, value))
            {
                return false;
            }

            if (name != null)
            {
                this.OnPropertyChanging(name);
            }

            property = value;

            if (name != null)
            {
                this.OnPropertyChanged(name);
            }

            return true;
        }

        event System.ComponentModel.PropertyChangingEventHandler System.ComponentModel.INotifyPropertyChanging.PropertyChanging
        {
            add => this.propertyChanging += value;
            remove => this.propertyChanging -= value;
        }

        event System.ComponentModel.PropertyChangedEventHandler System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        {
            add => this.propertyChanged += value;
            remove => this.propertyChanged -= value;
        }
    }
}
