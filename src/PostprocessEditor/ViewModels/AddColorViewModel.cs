using System.Windows;
using System.Windows.Input;

namespace PostprocessEditor.ViewModels {
    public class AddColorViewModel : ViewModelBase {
        public AddColorViewModel() {
        }

        private Visibility itensityLabelVisibility = Visibility.Collapsed;
        public Visibility ItensityLabelVisibility {
            get {
                return itensityLabelVisibility;
            }
            set {
                if (itensityLabelVisibility != value) {
                    itensityLabelVisibility = value;
                    NotifyPropertyChanged(nameof(ItensityLabelVisibility));
                }
            }
        }

        private Visibility itensityTextBoxVisibility = Visibility.Collapsed;
        public Visibility ItensityTextBoxVisibility {
            get {
                return itensityTextBoxVisibility;
            }
            set {
                if (itensityTextBoxVisibility != value) {
                    itensityTextBoxVisibility = value;
                    NotifyPropertyChanged(nameof(ItensityTextBoxVisibility));
                }
            }
        }

        private RelayCommand setColorCommand;
        public ICommand SetColorCommand => setColorCommand ??= new RelayCommand(_ => {
            // TODO ColorDialog
        });
    }
}
