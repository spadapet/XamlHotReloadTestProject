namespace WinUWP
{
    public sealed class DelegateCommand : PropertyNotifier, System.Windows.Input.ICommand
    {
        private bool? canExecute;
        private object canExecuteParam;
        private event System.EventHandler canExecuteChanged;
        private readonly System.Action<object> executeAction;
        private readonly System.Func<object, bool> canExecuteFunc;

        public DelegateCommand(System.Action executeAction, System.Func<bool> canExecuteFunc = null)
        {
            this.executeAction = (object arg) => executeAction?.Invoke();
            this.canExecuteFunc = (object arg) => canExecuteFunc?.Invoke() ?? true;
        }

        public DelegateCommand(System.Action<object> executeAction = null, System.Func<object, bool> canExecuteFunc = null)
        {
            this.executeAction = executeAction;
            this.canExecuteFunc = canExecuteFunc;
        }

        public void UpdateCanExecute()
        {
            this.canExecute = null;
            this.canExecuteParam = null;
            this.canExecuteChanged?.Invoke(this, System.EventArgs.Empty);
            this.OnPropertyChanged(nameof(this.CanExecute));
        }

        public bool CanExecute => this.CanExecuteParam(null);

        public bool CanExecuteParam(object parameter)
        {
            if (this.canExecute == null || !object.Equals(this.canExecuteParam, parameter))
            {
                this.canExecuteParam = parameter;
                this.canExecute = this.canExecuteFunc?.Invoke(parameter) ?? true;
            }

            return this.canExecute == true;
        }

        public void Execute()
        {
            this.ExecuteParam(null);
        }

        public void ExecuteParam(object parameter)
        {
            this.executeAction?.Invoke(parameter);
        }

        event System.EventHandler System.Windows.Input.ICommand.CanExecuteChanged
        {
            add => this.canExecuteChanged += value;
            remove => this.canExecuteChanged -= value;
        }

        bool System.Windows.Input.ICommand.CanExecute(object parameter)
        {
            return this.CanExecuteParam(parameter);
        }

        void System.Windows.Input.ICommand.Execute(object parameter)
        {
            this.ExecuteParam(parameter);
        }
    }
}
