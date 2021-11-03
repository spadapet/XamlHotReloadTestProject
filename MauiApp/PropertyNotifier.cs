﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiApp5
{
    public abstract class PropertyNotifier : INotifyPropertyChanging, INotifyPropertyChanged
    {
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;

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
            this.PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(name));
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
    }
}
