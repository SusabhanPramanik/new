using EmpWPF.Models;
using EmpWPF.ViewModels;
using FsCheck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EmpWPF
{
    public class Command : ICommand

    {
        Action<object> executedMethod;
        Func<object, bool> canexecuteMethod;

        public Command(Action<object> executedMethod, Func<object, bool> canexecuteMethod)
        {
            this.executedMethod = executedMethod;
            this.canexecuteMethod = canexecuteMethod;
        }

        public bool CanExecute(object parameter)
        {
            if (canexecuteMethod != null)
            {
                return canexecuteMethod(parameter);

            }
            else
            {
                return false;
            }
        }

        public void Execute(object parameter)
        {
            executedMethod(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
