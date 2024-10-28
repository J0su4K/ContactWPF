using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Cours_CommandMVVM
{
    public class CommandeExample : ICommand //Cette intefarce est definis par deux methodes clés . RelayCommand, "pattern de command le plus communément utilisé car très pratique et simple à faire et utiliser
    {
        //ELLE REPOSE SUR L'INTERFACE ICOMMAD
        public event EventHandler? CanExecuteChanged;
        Action<object> executeMethod = null;
        Action<object , int> executeMethodInt = null;
        Func<object , bool> canExecuteMethod = null;



        //CECI EST UN PATTERN DE COMMAND
        public CommandeExample(Action<object> _executeMethod , Func<object, bool> _canExecuteMethod)
        {
            executeMethod = _executeMethod;
            canExecuteMethod = _canExecuteMethod;
        }

        public CommandeExample(Action<object , int> _executeMethod, Func<object, bool> _canExecuteMethod)
        {
            executeMethodInt = _executeMethod;
            canExecuteMethod = _canExecuteMethod;
        }
        public bool CanExecute(object? parameter)
        {
            return true;
            //return (bool)canExecuteMethod?.Invoke(parameter);
        }

        public void Execute(object? parameter)
        {
            executeMethod?.Invoke(parameter);
           // executeMethodInt?.Invoke(parameter);
        }
    }
}
