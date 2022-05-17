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
            var form1 = new AddColorForm(false, false);
            foreach (var control in form1.Controls)
            {
                WorkArea1.Controls.Add((Control)control);
                
            }
            var form2 = new AddColorForm(false, false);
            foreach (var control in form2.Controls)
            {
                WorkArea2.Controls.Add((Control)control);
            }

            var form3 = new AddColorForm();
            foreach (var control in form3.Controls)
            {
                WorkArea3.Controls.Add((Control)control);
            }

            var form4 = new AddFloatForm("Duality-H", "Duality-V", string.Empty, 
                                         true, false, 
                                         true, false, 
                                         string.Empty, false);
            foreach (var control in form4.Controls)
            {
                WorkArea4.Controls.Add((Control)control);
            }

            var form5 = new AddFloatForm("Noise Intensity", "Noise Grain", "Noise FPS",
                                         true, true, 
                                         true, true, 
                                         string.Empty, false);
            foreach (var control in form5.Controls)
            {
                WorkArea5.Controls.Add((Control)control);
            }

            var form6 = new AddColorForm();
            foreach (var control in form6.Controls)
            {
                WorkArea6.Controls.Add((Control)control);
            }

            var form7 = new AddFloatForm("Influence", string.Empty, string.Empty, 
                                         false, false, 
                                         false, false,
                                         string.Empty, true);
            foreach (var control in form7.Controls)
            {
                WorkArea7.Controls.Add((Control)control);
            }
        }

        private void AddColorTabPage_Click(object sender, EventArgs e)
        {

        }
    }
}
