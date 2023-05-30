using Pureba2.Wpf.Models;
using System;
using System.Windows.Input;

namespace Pureba2.Wpf.Command
{
    public class DelegateCommand : ICommand
    {
        private Action _execute;
        private Func<bool> _canExecute;
        private Action<Persona> seleccionarPersona;

        public DelegateCommand(Action execute, Func<bool> canExecute = null)
        {
            this._execute = execute;
            this._canExecute = canExecute;
        }

        public DelegateCommand(Action<Persona> seleccionarPersona)
        {
            this.seleccionarPersona = seleccionarPersona;
        }

        public bool CanExecute(object parameter)
        {
            if (_canExecute == null)
                return true;
            return _canExecute();
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            _execute();
        }

        public void RaiseCanExecuteChanged()
        {
            if (CanExecuteChanged != null)
                CanExecuteChanged(this, new EventArgs());
        }
    }
}
