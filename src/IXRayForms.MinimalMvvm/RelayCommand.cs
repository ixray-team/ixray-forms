using System.Diagnostics;
using System.Windows.Input;

namespace IXRayForms.MinimalMvvm;

public class RelayCommand : ICommand {
    private readonly Action<object?> execute;
    private readonly Func<object?, bool>? canExecute;

    public RelayCommand(Action<object?> execute, Func<object?, bool>? canExecute = null) {
        this.execute = execute;
        this.canExecute = canExecute;
    }

    public event EventHandler? CanExecuteChanged {
        add {
            CommandManager.RequerySuggested += value;
        }
        remove {
            CommandManager.RequerySuggested -= value;
        }
    }

    public void Execute(object? parameter) {
        execute(parameter);
    }

    [DebuggerStepThrough]
    public bool CanExecute(object? parameter) {
        return canExecute == null || canExecute(parameter);
    }
}
