using System.Windows.Input;

namespace WPF_DZ9;

public class RelayCommand : ICommand {
    private Action<object?> execute;
    public RelayCommand (Action<object?> execute) {
        this.execute = execute;
    }

    public event EventHandler? CanExecuteChanged;
    public bool CanExecute (object? parameter) => true;

    public void Execute (object? parameter) => execute (parameter);
}
