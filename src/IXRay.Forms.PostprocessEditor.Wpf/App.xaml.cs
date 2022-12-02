using System.Windows;

using IXRay.Forms.PostprocessEditor.Wpf.Views;

namespace IXRay.Forms.PostprocessEditor.Wpf;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application {
    protected override void OnStartup(StartupEventArgs eventArgs) {
        base.OnStartup(eventArgs);

        var mainWindow = new MainWindow();
        mainWindow.Show();
    }
}
