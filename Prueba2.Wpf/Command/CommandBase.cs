using System;
using System.Windows.Input;

namespace Pureba2.Wpf.Command
{
    public abstract class CommandBase : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public virtual bool CanExecute(object parameter) => true;
        public abstract void Execute(object parameter);
        protected virtual void OnCanExecuteChanged(object parameter)
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }
    }
}
