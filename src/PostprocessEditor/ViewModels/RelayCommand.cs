﻿using System;
using System.Diagnostics;
using System.Windows.Input;

namespace PostprocessEditor.ViewModels {
    public class RelayCommand : ICommand {
        private readonly Action<object> execute;
        private readonly Predicate<object> canExecute;

        public RelayCommand(Action<object> execute, Predicate<object> canExecute) {
            this.execute = execute ?? throw new ArgumentNullException(nameof(execute));
            this.canExecute = canExecute;
        }

        public RelayCommand(Action<object> execute) : this(execute, null) {
        }

        public RelayCommand() : this(null, null) {
        }

        #region ICommand
        public event EventHandler CanExecuteChanged {
            add {
                CommandManager.RequerySuggested += value;
            }
            remove {
                CommandManager.RequerySuggested -= value;
            }
        }

        public void Execute(object parameter) {
            execute(parameter);
        }

        [DebuggerStepThrough]
        public bool CanExecute(object parameter) {
            return canExecute == null || canExecute(parameter);
        }
        #endregion
    }
}
