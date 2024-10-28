﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Cours_CommandMVVM.MVVM
{
    public class RelayCommand : ICommand
    {
        Action<object> execute = null;
        Func<object, bool> canExecute = null;
        public event EventHandler? CanExecuteChanged // Plus propre pour les events integrés command et on a accès au commandmanager pour gerer les ajouts/retraits de commande
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }


        public RelayCommand(Action<object> _execute, Func<object, bool> _canExecute = null)
        {
            execute = _execute;
            canExecute = _canExecute;
        }

        public bool CanExecute(object? parameter)
        {
            return canExecute==null || canExecute(parameter);
        }

        public void Execute(object? parameter)
        {
           execute(parameter);
        }
    }
}