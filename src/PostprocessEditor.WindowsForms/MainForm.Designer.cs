
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
            this.MainMenu1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewEffectMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LoadMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBar1 = new System.Windows.Forms.ToolStrip();
            this.NewEffectToolbarButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.LoadToolbarButton = new System.Windows.Forms.ToolStripButton();
            this.SaveToolbarButton = new System.Windows.Forms.ToolStripButton();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.OpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.RxLabel1 = new System.Windows.Forms.Label();
            this.PointList1 = new System.Windows.Forms.ListBox();
            this.btnAddKey1 = new System.Windows.Forms.Button();
            this.btnRemoveKey1 = new System.Windows.Forms.Button();
            this.ClearAll1 = new System.Windows.Forms.Button();
            this.CopyFrom1 = new System.Windows.Forms.Button();
            this.WorkArea1 = new System.Windows.Forms.Panel();
            this.Image = new System.Windows.Forms.PictureBox();
            this.RxLabel2 = new System.Windows.Forms.Label();
            this.PointList2 = new System.Windows.Forms.ListBox();
            this.btnAddKey2 = new System.Windows.Forms.Button();
            this.btnRemoveKey2 = new System.Windows.Forms.Button();
            this.ClearAll2 = new System.Windows.Forms.Button();
            this.CopyFrom2 = new System.Windows.Forms.Button();
            this.WorkArea2 = new System.Windows.Forms.Panel();
            this.MainMenu1.SuspendLayout();
            this.ToolBar1.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu1
            // 
            this.MainMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MainMenu1.Location = new System.Drawing.Point(0, 0);
            this.MainMenu1.Name = "MainMenu1";
            this.MainMenu1.Size = new System.Drawing.Size(800, 24);
            this.MainMenu1.TabIndex = 0;
            this.MainMenu1.Text = "menuStrip1";
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
            // ToolBar1
            // 
            this.ToolBar1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewEffectToolbarButton,
            this.toolStripSeparator2,
            this.LoadToolbarButton,
            this.SaveToolbarButton});
            this.ToolBar1.Location = new System.Drawing.Point(0, 24);
            this.ToolBar1.Name = "ToolBar1";
            this.ToolBar1.Size = new System.Drawing.Size(800, 25);
            this.ToolBar1.TabIndex = 1;
            this.ToolBar1.Text = "toolStrip1";
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
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Controls.Add(this.tabPage4);
            this.TabControl.Controls.Add(this.tabPage5);
            this.TabControl.Controls.Add(this.tabPage6);
            this.TabControl.Controls.Add(this.tabPage7);
            this.TabControl.Location = new System.Drawing.Point(0, 450);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(801, 251);
            this.TabControl.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.WorkArea1);
            this.tabPage1.Controls.Add(this.CopyFrom1);
            this.tabPage1.Controls.Add(this.ClearAll1);
            this.tabPage1.Controls.Add(this.btnRemoveKey1);
            this.tabPage1.Controls.Add(this.btnAddKey1);
            this.tabPage1.Controls.Add(this.PointList1);
            this.tabPage1.Controls.Add(this.RxLabel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 225);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add color";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.WorkArea2);
            this.tabPage2.Controls.Add(this.CopyFrom2);
            this.tabPage2.Controls.Add(this.ClearAll2);
            this.tabPage2.Controls.Add(this.btnRemoveKey2);
            this.tabPage2.Controls.Add(this.btnAddKey2);
            this.tabPage2.Controls.Add(this.PointList2);
            this.tabPage2.Controls.Add(this.RxLabel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 225);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Base color";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(793, 225);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Gray color";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(793, 225);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Duality";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(793, 225);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Noise";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(793, 225);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Blur";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(793, 225);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "ColorMapper";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // RxLabel1
            // 
            this.RxLabel1.Location = new System.Drawing.Point(28, 6);
            this.RxLabel1.Name = "RxLabel1";
            this.RxLabel1.Size = new System.Drawing.Size(48, 13);
            this.RxLabel1.TabIndex = 0;
            this.RxLabel1.Text = "Point list";
            // 
            // PointList1
            // 
            this.PointList1.FormattingEnabled = true;
            this.PointList1.Location = new System.Drawing.Point(6, 22);
            this.PointList1.Name = "PointList1";
            this.PointList1.Size = new System.Drawing.Size(144, 173);
            this.PointList1.TabIndex = 1;
            // 
            // btnAddKey1
            // 
            this.btnAddKey1.Location = new System.Drawing.Point(6, 200);
            this.btnAddKey1.Name = "btnAddKey1";
            this.btnAddKey1.Size = new System.Drawing.Size(17, 21);
            this.btnAddKey1.TabIndex = 2;
            this.btnAddKey1.Text = "+";
            this.btnAddKey1.UseVisualStyleBackColor = true;
            // 
            // btnRemoveKey1
            // 
            this.btnRemoveKey1.Location = new System.Drawing.Point(26, 200);
            this.btnRemoveKey1.Name = "btnRemoveKey1";
            this.btnRemoveKey1.Size = new System.Drawing.Size(17, 21);
            this.btnRemoveKey1.TabIndex = 3;
            this.btnRemoveKey1.Text = "-";
            this.btnRemoveKey1.UseVisualStyleBackColor = true;
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
            // CopyFrom1
            // 
            this.CopyFrom1.Location = new System.Drawing.Point(88, 200);
            this.CopyFrom1.Name = "CopyFrom1";
            this.CopyFrom1.Size = new System.Drawing.Size(62, 21);
            this.CopyFrom1.TabIndex = 5;
            this.CopyFrom1.Text = "CopyFrom";
            this.CopyFrom1.UseVisualStyleBackColor = true;
            // 
            // WorkArea1
            // 
            this.WorkArea1.Location = new System.Drawing.Point(156, 6);
            this.WorkArea1.Name = "WorkArea1";
            this.WorkArea1.Size = new System.Drawing.Size(628, 216);
            this.WorkArea1.TabIndex = 6;
            // 
            // Image
            // 
            this.Image.Location = new System.Drawing.Point(4, 52);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(793, 392);
            this.Image.TabIndex = 4;
            this.Image.TabStop = false;
            // 
            // RxLabel2
            // 
            this.RxLabel2.Location = new System.Drawing.Point(28, 6);
            this.RxLabel2.Name = "RxLabel2";
            this.RxLabel2.Size = new System.Drawing.Size(48, 13);
            this.RxLabel2.TabIndex = 1;
            this.RxLabel2.Text = "Point list";
            // 
            // PointList2
            // 
            this.PointList2.FormattingEnabled = true;
            this.PointList2.Location = new System.Drawing.Point(6, 22);
            this.PointList2.Name = "PointList2";
            this.PointList2.Size = new System.Drawing.Size(144, 173);
            this.PointList2.TabIndex = 2;
            // 
            // btnAddKey2
            // 
            this.btnAddKey2.Location = new System.Drawing.Point(6, 200);
            this.btnAddKey2.Name = "btnAddKey2";
            this.btnAddKey2.Size = new System.Drawing.Size(17, 21);
            this.btnAddKey2.TabIndex = 3;
            this.btnAddKey2.Text = "+";
            this.btnAddKey2.UseVisualStyleBackColor = true;
            // 
            // btnRemoveKey2
            // 
            this.btnRemoveKey2.Location = new System.Drawing.Point(26, 200);
            this.btnRemoveKey2.Name = "btnRemoveKey2";
            this.btnRemoveKey2.Size = new System.Drawing.Size(17, 21);
            this.btnRemoveKey2.TabIndex = 4;
            this.btnRemoveKey2.Text = "-";
            this.btnRemoveKey2.UseVisualStyleBackColor = true;
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
            // CopyFrom2
            // 
            this.CopyFrom2.Location = new System.Drawing.Point(88, 200);
            this.CopyFrom2.Name = "CopyFrom2";
            this.CopyFrom2.Size = new System.Drawing.Size(62, 21);
            this.CopyFrom2.TabIndex = 6;
            this.CopyFrom2.Text = "CopyFrom";
            this.CopyFrom2.UseVisualStyleBackColor = true;
            // 
            // WorkArea2
            // 
            this.WorkArea2.Location = new System.Drawing.Point(156, 6);
            this.WorkArea2.Name = "WorkArea2";
            this.WorkArea2.Size = new System.Drawing.Size(628, 216);
            this.WorkArea2.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 726);
            this.Controls.Add(this.Image);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.ToolBar1);
            this.Controls.Add(this.MainMenu1);
            this.MainMenuStrip = this.MainMenu1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu1.ResumeLayout(false);
            this.MainMenu1.PerformLayout();
            this.ToolBar1.ResumeLayout(false);
            this.ToolBar1.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewEffectMenuButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem LoadMenuButton;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuButton;
        private System.Windows.Forms.ToolStrip ToolBar1;
        private System.Windows.Forms.ToolStripButton NewEffectToolbarButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton LoadToolbarButton;
        private System.Windows.Forms.ToolStripButton SaveToolbarButton;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.OpenFileDialog OpenDialog;
        private System.Windows.Forms.SaveFileDialog SaveDialog;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel WorkArea1;
        private System.Windows.Forms.Button CopyFrom1;
        private System.Windows.Forms.Button ClearAll1;
        private System.Windows.Forms.Button btnRemoveKey1;
        private System.Windows.Forms.Button btnAddKey1;
        private System.Windows.Forms.ListBox PointList1;
        private System.Windows.Forms.Label RxLabel1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.PictureBox Image;
        private System.Windows.Forms.Label RxLabel2;
        private System.Windows.Forms.Button btnAddKey2;
        private System.Windows.Forms.ListBox PointList2;
        private System.Windows.Forms.Button btnRemoveKey2;
        private System.Windows.Forms.Button ClearAll2;
        private System.Windows.Forms.Button CopyFrom2;
        private System.Windows.Forms.Panel WorkArea2;
    }
}

