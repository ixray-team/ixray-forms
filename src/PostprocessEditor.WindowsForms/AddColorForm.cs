namespace PostprocessEditor.WindowsForms;

public partial class AddColorForm : Form {
    public AddColorForm() {
        InitializeComponent();
    }

    public AddColorForm(bool intensityLabelVisible, bool intensityValueVisible) : this() {
        labelIntensity.Visible = intensityLabelVisible;
        IntensityValue.Visible = intensityValueVisible;
    }

    private void Color_Click(object sender, EventArgs e) {
        ColorDialog.ShowDialog();
    }
}
