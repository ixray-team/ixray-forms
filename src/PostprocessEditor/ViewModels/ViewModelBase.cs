using System;
using System.ComponentModel;
using System.Diagnostics;

namespace PostprocessEditor.ViewModels {
    public abstract class ViewModelBase : INotifyPropertyChanged {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        [Conditional("DEBUG")]
        [DebuggerStepThrough]
        public virtual void VerifyPropertyName(string propertyName) {
            if (TypeDescriptor.GetProperties(this)[propertyName] == null) {
                throw new Exception(GetType().Name + " does not contain property " + propertyName);
            }
        }

        protected virtual void NotifyPropertyChanged(PropertyChangedEventArgs eventArgs) {
            PropertyChanged?.Invoke(this, eventArgs);
        }

        protected void NotifyPropertyChanged(string propertyName) {
            VerifyPropertyName(propertyName);
            NotifyPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }
    }
}
