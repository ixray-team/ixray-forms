using System.Windows.Forms;

namespace PostprocessEditor.WindowsForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        void NewEffectDialog()
        {
            MessageBox.Show("Do you wish to create a new effect ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        void LoadEffectDialog()
        {
            OpenDialog.ShowDialog();
        }
        void SaveEffectDialog()
        {
            SaveDialog.ShowDialog();
        }

        private void NewEffectMenuButton_Click(object sender, System.EventArgs e)
        {
            NewEffectDialog();
        }
        private void NewEffectToolbarButton_Click(object sender, System.EventArgs e)
        {
            NewEffectDialog();
        }
        private void LoadMenuButton_Click(object sender, System.EventArgs e)
        {
            LoadEffectDialog();
        }
        private void LoadToolbarButton_Click(object sender, System.EventArgs e)
        {
            LoadEffectDialog();
        }
        private void SaveMenuButton_Click(object sender, System.EventArgs e)
        {
            SaveEffectDialog();
        }
        private void SaveToolbarButton_Click(object sender, System.EventArgs e)
        {
            SaveEffectDialog();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            var form1 = new AddColorForm();
            foreach (var control in form1.Controls)
            {
                WorkArea1.Controls.Add((Control)control);
            }

            var form2 = new AddColorForm();
            foreach (var control in form2.Controls)
            {
                WorkArea2.Controls.Add((Control)control);
            }
        }
    }
}
