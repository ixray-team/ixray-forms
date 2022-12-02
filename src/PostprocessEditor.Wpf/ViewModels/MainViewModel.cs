using System.Collections.ObjectModel;
using System.Windows;

using Microsoft.Win32;

using ImeSense.Helpers.Mvvm.ComponentModel;
using ImeSense.Helpers.Mvvm.Input;

namespace PostprocessEditor.ViewModels;

public class MainViewModel : ObservableObject {
    public MainViewModel() {
        // Add color
        AddColorViewModels.Add(new AddColorViewModel());
        // Base color
        AddColorViewModels.Add(new AddColorViewModel());
        // Gray color
        AddColorViewModels.Add(new AddColorViewModel {
            ItensityLabelVisibility = Visibility.Visible,
            ItensityTextBoxVisibility = Visibility.Visible
        });
        // Blur
        AddColorViewModels.Add(new AddColorViewModel {
            ItensityLabelVisibility = Visibility.Visible,
            ItensityTextBoxVisibility = Visibility.Visible
        });
    }

    private void NewFile() {
        _ = MessageBox.Show("Do you wish to create a new effect ?", "Warning",
            MessageBoxButton.YesNo, MessageBoxImage.Question);
    }

    private IRelayCommand? newFileCommand;
    public IRelayCommand NewFileCommand => newFileCommand ??= new RelayCommand(NewFile);

    private void LoadFile() {
        var openFileDialog = new OpenFileDialog {
            DefaultExt = "ppe",
            Filter = "Postprocess files (*.ppe)|*.ppe|All files (*.*)|*.*",
            Title = "Open postprocess effect"
        };
        _ = openFileDialog.ShowDialog();
    }

    private IRelayCommand? loadFileCommand;
    public IRelayCommand LoadFileCommand => loadFileCommand ??= new RelayCommand(LoadFile);

    private void SaveFile() {
        var saveFileDialog = new SaveFileDialog {
            DefaultExt = "ppe",
            Filter = "Postprocess files (*.ppe)|*.ppe|All files (*.*)|*.*",
            Title = "Save postprocess effect"
        };
        _ = saveFileDialog.ShowDialog();
    }

    private IRelayCommand? saveFileCommand;
    public IRelayCommand SaveFileCommand => saveFileCommand ??= new RelayCommand(SaveFile);

    private ObservableCollection<AddColorViewModel> addColorViewModels = new();
    public ObservableCollection<AddColorViewModel> AddColorViewModels {
        get => addColorViewModels;
        set => SetProperty(ref addColorViewModels, value);
    }
}
