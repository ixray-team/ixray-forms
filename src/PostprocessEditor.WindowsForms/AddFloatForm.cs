using System.Windows.Forms;

namespace PostprocessEditor.WindowsForms
{
    public partial class AddFloatForm : Form
    {
        public AddFloatForm()
        {
            InitializeComponent();
        }
        public AddFloatForm(string label1Text, string label2Text, string label3Text,
                            bool label2Visibility, bool label3Visibility, 
                            bool value2Visibility, bool value3Visibility, 
                            string textureNameText, bool textureNameVisibility)
        {
            InitializeComponent();

            Label1.Text = label1Text;
            Label2.Text = label2Text;
            Label3.Text = label3Text;
            Label2.Visible = label2Visibility;
            Label3.Visible = label3Visibility;

            Value2.Visible = value2Visibility;
            Value3.Visible = value3Visibility;

            cmTextureName.Text = textureNameText;
            cmTextureName.Visible = textureNameVisibility;
        }
    }
}
