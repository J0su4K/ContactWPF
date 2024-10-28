using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RepertoryContact.Utils
{
    public class RelayCommand : ICommand
    {
        Action<object> execute = null;
        Func<object, bool> canExecute = null;
        public event EventHandler? CanExecuteChanged;


        public RelayCommand() { }
        public RelayCommand(Action<object> _execute, Func<object, bool> _canExecute = null)
        {
            execute = _execute;
            canExecute = _canExecute;
        }

        public bool CanExecute(object? parameter)
        {
            return canExecute == null || canExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            execute(parameter);
        }
    }
}
