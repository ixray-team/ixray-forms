using System.Windows;

using PostprocessEditor.Views;

namespace PostprocessEditor;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application {
    protected override void OnStartup(StartupEventArgs eventArgs) {
        base.OnStartup(eventArgs);

        var window = new MainWindow();
        window.Show();
    }
}
