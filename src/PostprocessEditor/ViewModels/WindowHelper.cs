using System.Windows;

namespace PostprocessEditor.ViewModels {
    public static class WindowHelper {
        public static void CloseWindowByContext(object context) {
            foreach (Window window in Application.Current.Windows) {
                if (window.DataContext == context) {
                    window.Close();
                }
            }
        }
    }
}
