using System.Windows;

using ImeSense.Helpers.Mvvm.ComponentModel;
using ImeSense.Helpers.Mvvm.Input;

namespace IXRay.Forms.PostprocessEditor.Wpf.ViewModels;

public class AddColorViewModel : ObservableObject {
    public AddColorViewModel() {
        ItensityLabelVisibility = Visibility.Collapsed;
        ItensityTextBoxVisibility = Visibility.Collapsed;
    }

    private Visibility itensityLabelVisibility;
    public Visibility ItensityLabelVisibility {
        get => itensityLabelVisibility;
        set => SetProperty(ref itensityLabelVisibility, value);
    }

    private Visibility itensityTextBoxVisibility;
    public Visibility ItensityTextBoxVisibility {
        get => itensityTextBoxVisibility;
        set => SetProperty(ref itensityTextBoxVisibility, value);
    }

    private void SetColor() {
        // TODO ColorDialog
    }

    private IRelayCommand? setColorCommand;
    public IRelayCommand SetColorCommand => setColorCommand ??= new RelayCommand(SetColor);
}
