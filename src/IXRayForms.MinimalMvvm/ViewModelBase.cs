using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace IXRayForms.MinimalMvvm;

public abstract class ViewModelBase : INotifyPropertyChanged {
    public event PropertyChangedEventHandler? PropertyChanged;

    [Conditional("DEBUG")]
    [DebuggerStepThrough]
    protected virtual void VerifyPropertyName(string propertyName) {
        if (TypeDescriptor.GetProperties(this)[propertyName] == null) {
            throw new Exception(GetType().Name + " does not contain " + propertyName);
        }
    }

    protected virtual void NotifyPropertyChanged(PropertyChangedEventArgs e) {
        PropertyChanged?.Invoke(this, e);
    }

    public void NotifyPropertyChanged([CallerMemberName] string propertyName = "") {
        VerifyPropertyName(propertyName);
        NotifyPropertyChanged(new PropertyChangedEventArgs(propertyName));
    }
}
