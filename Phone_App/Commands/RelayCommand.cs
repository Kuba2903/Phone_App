using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Phone_App.Commands
{
    public class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private Action<object> _Execute { get; set; }
        private Predicate<object> _canExecute { get; set; }

        public RelayCommand(Action<object> Execute, Predicate<object> canExecute)
        {
            _Execute = Execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object? parameter) => _canExecute(parameter);

        public void Execute(object? parameter) => _Execute(parameter);
    }
}
