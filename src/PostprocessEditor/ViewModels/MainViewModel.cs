using System.Windows;
using System.Windows.Input;

using Microsoft.Win32;

namespace PostprocessEditor.ViewModels {
    public class MainViewModel : ViewModelBase {
        public MainViewModel() {
        }

        private RelayCommand newFileCommand;
        public ICommand NewFileCommand => newFileCommand ??= new RelayCommand(_ => {
            _ = MessageBox.Show("Do you wish to create a new effect ?", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Question);
        });

        private RelayCommand loadFileCommand;
        public ICommand LoadFileCommand => loadFileCommand ??= new RelayCommand(_ => {
            var openFileDialog = new OpenFileDialog {
                DefaultExt = "ppe",
                Filter = "Postprocess files (*.ppe)|*.ppe|All files (*.*)|*.*",
                Title = "Open postprocess effect"
            };
            _ = openFileDialog.ShowDialog();
        });

        private RelayCommand saveFileCommand;
        public ICommand SaveFileCommand => saveFileCommand ??= new RelayCommand(_ => {
            var saveFileDialog = new SaveFileDialog {
                DefaultExt = "ppe",
                Filter = "Postprocess files (*.ppe)|*.ppe|All files (*.*)|*.*",
                Title = "Save postprocess effect"
            };
            _ = saveFileDialog.ShowDialog();
        });
    }
}
