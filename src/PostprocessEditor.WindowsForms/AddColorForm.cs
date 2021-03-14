using System;
using System.Windows.Forms;

namespace PostprocessEditor.WindowsForms
{
    public partial class AddColorForm : Form
    {
        public AddColorForm()
        {
            InitializeComponent();
        }

        private void Color_Click(object sender, EventArgs e)
        {
            ColorDialog.ShowDialog();
        }
    }
}
