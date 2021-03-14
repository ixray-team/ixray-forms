
namespace PostprocessEditor.WindowsForms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewEffectMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LoadMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.NewEffectToolbarButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.LoadToolbarButton = new System.Windows.Forms.ToolStripButton();
            this.SaveToolbarButton = new System.Windows.Forms.ToolStripButton();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.OpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.AddColorTabPage = new System.Windows.Forms.TabPage();
            this.WorkArea1 = new System.Windows.Forms.Panel();
            this.CopyFrom1 = new System.Windows.Forms.Button();
            this.ClearAll1 = new System.Windows.Forms.Button();
            this.RemoveKey1 = new System.Windows.Forms.Button();
            this.AddKey1 = new System.Windows.Forms.Button();
            this.PointList1 = new System.Windows.Forms.ListBox();
            this.RxLabel1 = new System.Windows.Forms.Label();
            this.BaseColorTabPage = new System.Windows.Forms.TabPage();
            this.WorkArea2 = new System.Windows.Forms.Panel();
            this.CopyFrom2 = new System.Windows.Forms.Button();
            this.ClearAll2 = new System.Windows.Forms.Button();
            this.RemoveKey2 = new System.Windows.Forms.Button();
            this.AddKey2 = new System.Windows.Forms.Button();
            this.PointList2 = new System.Windows.Forms.ListBox();
            this.RxLabel2 = new System.Windows.Forms.Label();
            this.GrayColorTabPage = new System.Windows.Forms.TabPage();
            this.DualityTabPage = new System.Windows.Forms.TabPage();
            this.NoiseTabPage = new System.Windows.Forms.TabPage();
            this.BlurTabPage = new System.Windows.Forms.TabPage();
            this.ColorMapperTabPage = new System.Windows.Forms.TabPage();
            this.Image = new System.Windows.Forms.PictureBox();
            this.MainMenu.SuspendLayout();
            this.ToolBar.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.AddColorTabPage.SuspendLayout();
            this.BaseColorTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(800, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewEffectMenuButton,
            this.toolStripSeparator1,
            this.LoadMenuButton,
            this.SaveMenuButton});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // NewEffectMenuButton
            // 
            this.NewEffectMenuButton.Name = "NewEffectMenuButton";
            this.NewEffectMenuButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewEffectMenuButton.Size = new System.Drawing.Size(143, 22);
            this.NewEffectMenuButton.Text = "New";
            this.NewEffectMenuButton.Click += new System.EventHandler(this.NewEffectMenuButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
            // 
            // LoadMenuButton
            // 
            this.LoadMenuButton.Name = "LoadMenuButton";
            this.LoadMenuButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.LoadMenuButton.Size = new System.Drawing.Size(143, 22);
            this.LoadMenuButton.Text = "Load";
            this.LoadMenuButton.Click += new System.EventHandler(this.LoadMenuButton_Click);
            // 
            // SaveMenuButton
            // 
            this.SaveMenuButton.Name = "SaveMenuButton";
            this.SaveMenuButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveMenuButton.Size = new System.Drawing.Size(143, 22);
            this.SaveMenuButton.Text = "Save";
            this.SaveMenuButton.Click += new System.EventHandler(this.SaveMenuButton_Click);
            // 
            // ToolBar
            // 
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewEffectToolbarButton,
            this.toolStripSeparator2,
            this.LoadToolbarButton,
            this.SaveToolbarButton});
            this.ToolBar.Location = new System.Drawing.Point(0, 24);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(800, 25);
            this.ToolBar.TabIndex = 1;
            this.ToolBar.Text = "toolStrip1";
            // 
            // NewEffectToolbarButton
            // 
            this.NewEffectToolbarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewEffectToolbarButton.Image = ((System.Drawing.Image)(resources.GetObject("NewEffectToolbarButton.Image")));
            this.NewEffectToolbarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewEffectToolbarButton.Name = "NewEffectToolbarButton";
            this.NewEffectToolbarButton.Size = new System.Drawing.Size(23, 22);
            this.NewEffectToolbarButton.Text = "toolStripButton1";
            this.NewEffectToolbarButton.Click += new System.EventHandler(this.NewEffectToolbarButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // LoadToolbarButton
            // 
            this.LoadToolbarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LoadToolbarButton.Image = ((System.Drawing.Image)(resources.GetObject("LoadToolbarButton.Image")));
            this.LoadToolbarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LoadToolbarButton.Name = "LoadToolbarButton";
            this.LoadToolbarButton.Size = new System.Drawing.Size(23, 22);
            this.LoadToolbarButton.Text = "toolStripButton2";
            this.LoadToolbarButton.Click += new System.EventHandler(this.LoadToolbarButton_Click);
            // 
            // SaveToolbarButton
            // 
            this.SaveToolbarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveToolbarButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolbarButton.Image")));
            this.SaveToolbarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolbarButton.Name = "SaveToolbarButton";
            this.SaveToolbarButton.Size = new System.Drawing.Size(23, 22);
            this.SaveToolbarButton.Text = "toolStripButton3";
            this.SaveToolbarButton.Click += new System.EventHandler(this.SaveToolbarButton_Click);
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.StatusBar.Location = new System.Drawing.Point(0, 704);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(800, 22);
            this.StatusBar.TabIndex = 2;
            this.StatusBar.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(100, 17);
            this.toolStripStatusLabel1.Text = "Effect time : 0.000";
            // 
            // OpenDialog
            // 
            this.OpenDialog.DefaultExt = "ppe";
            this.OpenDialog.Filter = "Postprocess files (*.ppe)|*.ppe|All files (*.*)|*.*";
            this.OpenDialog.Title = "Open postprocess effect";
            // 
            // SaveDialog
            // 
            this.SaveDialog.DefaultExt = "ppe";
            this.SaveDialog.Filter = "Postprocess files (*.ppe)|*.ppe|All files (*.*)|*.*";
            this.SaveDialog.Title = "Save postprocess effect";
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.AddColorTabPage);
            this.TabControl.Controls.Add(this.BaseColorTabPage);
            this.TabControl.Controls.Add(this.GrayColorTabPage);
            this.TabControl.Controls.Add(this.DualityTabPage);
            this.TabControl.Controls.Add(this.NoiseTabPage);
            this.TabControl.Controls.Add(this.BlurTabPage);
            this.TabControl.Controls.Add(this.ColorMapperTabPage);
            this.TabControl.Location = new System.Drawing.Point(0, 450);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(801, 251);
            this.TabControl.TabIndex = 3;
            // 
            // AddColorTabPage
            // 
            this.AddColorTabPage.Controls.Add(this.WorkArea1);
            this.AddColorTabPage.Controls.Add(this.CopyFrom1);
            this.AddColorTabPage.Controls.Add(this.ClearAll1);
            this.AddColorTabPage.Controls.Add(this.RemoveKey1);
            this.AddColorTabPage.Controls.Add(this.AddKey1);
            this.AddColorTabPage.Controls.Add(this.PointList1);
            this.AddColorTabPage.Controls.Add(this.RxLabel1);
            this.AddColorTabPage.Location = new System.Drawing.Point(4, 22);
            this.AddColorTabPage.Name = "AddColorTabPage";
            this.AddColorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AddColorTabPage.Size = new System.Drawing.Size(793, 225);
            this.AddColorTabPage.TabIndex = 0;
            this.AddColorTabPage.Text = "Add color";
            this.AddColorTabPage.UseVisualStyleBackColor = true;
            // 
            // WorkArea1
            // 
            this.WorkArea1.Location = new System.Drawing.Point(156, 6);
            this.WorkArea1.Name = "WorkArea1";
            this.WorkArea1.Size = new System.Drawing.Size(628, 216);
            this.WorkArea1.TabIndex = 6;
            // 
            // CopyFrom1
            // 
            this.CopyFrom1.Location = new System.Drawing.Point(88, 200);
            this.CopyFrom1.Name = "CopyFrom1";
            this.CopyFrom1.Size = new System.Drawing.Size(62, 21);
            this.CopyFrom1.TabIndex = 5;
            this.CopyFrom1.Text = "CopyFrom";
            this.CopyFrom1.UseVisualStyleBackColor = true;
            // 
            // ClearAll1
            // 
            this.ClearAll1.Location = new System.Drawing.Point(46, 200);
            this.ClearAll1.Name = "ClearAll1";
            this.ClearAll1.Size = new System.Drawing.Size(39, 21);
            this.ClearAll1.TabIndex = 4;
            this.ClearAll1.Text = "Clear";
            this.ClearAll1.UseVisualStyleBackColor = true;
            // 
            // RemoveKey1
            // 
            this.RemoveKey1.Location = new System.Drawing.Point(26, 200);
            this.RemoveKey1.Name = "RemoveKey1";
            this.RemoveKey1.Size = new System.Drawing.Size(17, 21);
            this.RemoveKey1.TabIndex = 3;
            this.RemoveKey1.Text = "-";
            this.RemoveKey1.UseVisualStyleBackColor = true;
            // 
            // AddKey1
            // 
            this.AddKey1.Location = new System.Drawing.Point(6, 200);
            this.AddKey1.Name = "AddKey1";
            this.AddKey1.Size = new System.Drawing.Size(17, 21);
            this.AddKey1.TabIndex = 2;
            this.AddKey1.Text = "+";
            this.AddKey1.UseVisualStyleBackColor = true;
            // 
            // PointList1
            // 
            this.PointList1.FormattingEnabled = true;
            this.PointList1.Location = new System.Drawing.Point(6, 22);
            this.PointList1.Name = "PointList1";
            this.PointList1.Size = new System.Drawing.Size(144, 173);
            this.PointList1.TabIndex = 1;
            // 
            // RxLabel1
            // 
            this.RxLabel1.Location = new System.Drawing.Point(28, 6);
            this.RxLabel1.Name = "RxLabel1";
            this.RxLabel1.Size = new System.Drawing.Size(48, 13);
            this.RxLabel1.TabIndex = 0;
            this.RxLabel1.Text = "Point list";
            // 
            // BaseColorTabPage
            // 
            this.BaseColorTabPage.Controls.Add(this.WorkArea2);
            this.BaseColorTabPage.Controls.Add(this.CopyFrom2);
            this.BaseColorTabPage.Controls.Add(this.ClearAll2);
            this.BaseColorTabPage.Controls.Add(this.RemoveKey2);
            this.BaseColorTabPage.Controls.Add(this.AddKey2);
            this.BaseColorTabPage.Controls.Add(this.PointList2);
            this.BaseColorTabPage.Controls.Add(this.RxLabel2);
            this.BaseColorTabPage.Location = new System.Drawing.Point(4, 22);
            this.BaseColorTabPage.Name = "BaseColorTabPage";
            this.BaseColorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.BaseColorTabPage.Size = new System.Drawing.Size(793, 225);
            this.BaseColorTabPage.TabIndex = 1;
            this.BaseColorTabPage.Text = "Base color";
            this.BaseColorTabPage.UseVisualStyleBackColor = true;
            // 
            // WorkArea2
            // 
            this.WorkArea2.Location = new System.Drawing.Point(156, 6);
            this.WorkArea2.Name = "WorkArea2";
            this.WorkArea2.Size = new System.Drawing.Size(628, 216);
            this.WorkArea2.TabIndex = 7;
            // 
            // CopyFrom2
            // 
            this.CopyFrom2.Location = new System.Drawing.Point(88, 200);
            this.CopyFrom2.Name = "CopyFrom2";
            this.CopyFrom2.Size = new System.Drawing.Size(62, 21);
            this.CopyFrom2.TabIndex = 6;
            this.CopyFrom2.Text = "CopyFrom";
            this.CopyFrom2.UseVisualStyleBackColor = true;
            // 
            // ClearAll2
            // 
            this.ClearAll2.Location = new System.Drawing.Point(46, 200);
            this.ClearAll2.Name = "ClearAll2";
            this.ClearAll2.Size = new System.Drawing.Size(39, 21);
            this.ClearAll2.TabIndex = 5;
            this.ClearAll2.Text = "Clear";
            this.ClearAll2.UseVisualStyleBackColor = true;
            // 
            // RemoveKey2
            // 
            this.RemoveKey2.Location = new System.Drawing.Point(26, 200);
            this.RemoveKey2.Name = "RemoveKey2";
            this.RemoveKey2.Size = new System.Drawing.Size(17, 21);
            this.RemoveKey2.TabIndex = 4;
            this.RemoveKey2.Text = "-";
            this.RemoveKey2.UseVisualStyleBackColor = true;
            // 
            // AddKey2
            // 
            this.AddKey2.Location = new System.Drawing.Point(6, 200);
            this.AddKey2.Name = "AddKey2";
            this.AddKey2.Size = new System.Drawing.Size(17, 21);
            this.AddKey2.TabIndex = 3;
            this.AddKey2.Text = "+";
            this.AddKey2.UseVisualStyleBackColor = true;
            // 
            // PointList2
            // 
            this.PointList2.FormattingEnabled = true;
            this.PointList2.Location = new System.Drawing.Point(6, 22);
            this.PointList2.Name = "PointList2";
            this.PointList2.Size = new System.Drawing.Size(144, 173);
            this.PointList2.TabIndex = 2;
            // 
            // RxLabel2
            // 
            this.RxLabel2.Location = new System.Drawing.Point(28, 6);
            this.RxLabel2.Name = "RxLabel2";
            this.RxLabel2.Size = new System.Drawing.Size(48, 13);
            this.RxLabel2.TabIndex = 1;
            this.RxLabel2.Text = "Point list";
            // 
            // GrayColorTabPage
            // 
            this.GrayColorTabPage.Location = new System.Drawing.Point(4, 22);
            this.GrayColorTabPage.Name = "GrayColorTabPage";
            this.GrayColorTabPage.Size = new System.Drawing.Size(793, 225);
            this.GrayColorTabPage.TabIndex = 2;
            this.GrayColorTabPage.Text = "Gray color";
            this.GrayColorTabPage.UseVisualStyleBackColor = true;
            // 
            // DualityTabPage
            // 
            this.DualityTabPage.Location = new System.Drawing.Point(4, 22);
            this.DualityTabPage.Name = "DualityTabPage";
            this.DualityTabPage.Size = new System.Drawing.Size(793, 225);
            this.DualityTabPage.TabIndex = 3;
            this.DualityTabPage.Text = "Duality";
            this.DualityTabPage.UseVisualStyleBackColor = true;
            // 
            // NoiseTabPage
            // 
            this.NoiseTabPage.Location = new System.Drawing.Point(4, 22);
            this.NoiseTabPage.Name = "NoiseTabPage";
            this.NoiseTabPage.Size = new System.Drawing.Size(793, 225);
            this.NoiseTabPage.TabIndex = 4;
            this.NoiseTabPage.Text = "Noise";
            this.NoiseTabPage.UseVisualStyleBackColor = true;
            // 
            // BlurTabPage
            // 
            this.BlurTabPage.Location = new System.Drawing.Point(4, 22);
            this.BlurTabPage.Name = "BlurTabPage";
            this.BlurTabPage.Size = new System.Drawing.Size(793, 225);
            this.BlurTabPage.TabIndex = 5;
            this.BlurTabPage.Text = "Blur";
            this.BlurTabPage.UseVisualStyleBackColor = true;
            // 
            // ColorMapperTabPage
            // 
            this.ColorMapperTabPage.Location = new System.Drawing.Point(4, 22);
            this.ColorMapperTabPage.Name = "ColorMapperTabPage";
            this.ColorMapperTabPage.Size = new System.Drawing.Size(793, 225);
            this.ColorMapperTabPage.TabIndex = 6;
            this.ColorMapperTabPage.Text = "ColorMapper";
            this.ColorMapperTabPage.UseVisualStyleBackColor = true;
            // 
            // Image
            // 
            this.Image.BackColor = System.Drawing.Color.White;
            this.Image.Location = new System.Drawing.Point(4, 52);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(793, 392);
            this.Image.TabIndex = 4;
            this.Image.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 726);
            this.Controls.Add(this.Image);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.AddColorTabPage.ResumeLayout(false);
            this.BaseColorTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewEffectMenuButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem LoadMenuButton;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuButton;
        private System.Windows.Forms.ToolStrip ToolBar;
        private System.Windows.Forms.ToolStripButton NewEffectToolbarButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton LoadToolbarButton;
        private System.Windows.Forms.ToolStripButton SaveToolbarButton;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.OpenFileDialog OpenDialog;
        private System.Windows.Forms.SaveFileDialog SaveDialog;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage AddColorTabPage;
        private System.Windows.Forms.TabPage BaseColorTabPage;
        private System.Windows.Forms.Panel WorkArea1;
        private System.Windows.Forms.Button CopyFrom1;
        private System.Windows.Forms.Button ClearAll1;
        private System.Windows.Forms.Button RemoveKey1;
        private System.Windows.Forms.Button AddKey1;
        private System.Windows.Forms.ListBox PointList1;
        private System.Windows.Forms.Label RxLabel1;
        private System.Windows.Forms.TabPage GrayColorTabPage;
        private System.Windows.Forms.TabPage DualityTabPage;
        private System.Windows.Forms.TabPage NoiseTabPage;
        private System.Windows.Forms.TabPage BlurTabPage;
        private System.Windows.Forms.TabPage ColorMapperTabPage;
        private System.Windows.Forms.PictureBox Image;
        private System.Windows.Forms.Label RxLabel2;
        private System.Windows.Forms.Button AddKey2;
        private System.Windows.Forms.ListBox PointList2;
        private System.Windows.Forms.Button RemoveKey2;
        private System.Windows.Forms.Button ClearAll2;
        private System.Windows.Forms.Button CopyFrom2;
        private System.Windows.Forms.Panel WorkArea2;
    }
}

