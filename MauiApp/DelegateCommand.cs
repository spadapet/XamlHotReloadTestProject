using System;
using System.Windows.Input;

namespace MauiApp5
{
    public sealed class DelegateCommand : PropertyNotifier, ICommand
    {
        public event EventHandler CanExecuteChanged;
        public bool CanExecuteNullParameter => this.CanExecute(null);

        private bool? canExecute;
        private object canExecuteParam;
        private readonly Action<object> executeAction;
        private readonly Func<object, bool> canExecuteFunc;

        public DelegateCommand(Action executeAction, Func<bool> canExecuteFunc = null)
        {
            this.executeAction = (object arg) => executeAction?.Invoke();
            this.canExecuteFunc = (object arg) => canExecuteFunc?.Invoke() ?? true;
        }

        public DelegateCommand(Action<object> executeAction = null, Func<object, bool> canExecuteFunc = null)
        {
            this.executeAction = executeAction;
            this.canExecuteFunc = canExecuteFunc;
        }

        public void UpdateCanExecute()
        {
            this.canExecute = null;
            this.canExecuteParam = null;
            this.CanExecuteChanged?.Invoke(this, EventArgs.Empty);
            this.OnPropertyChanged(nameof(this.CanExecuteNullParameter));
        }

        public bool CanExecute(object parameter)
        {
            if (this.canExecute == null || !object.Equals(this.canExecuteParam, parameter))
            {
                this.canExecuteParam = parameter;
                this.canExecute = this.canExecuteFunc?.Invoke(parameter) ?? true;
            }

            return this.canExecute == true;
        }

        public void Execute(object parameter)
        {
            this.executeAction?.Invoke(parameter);
        }
    }
}
