
namespace PostprocessEditor.WindowsForms
{
    partial class frmTimeConstructor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel1 = new System.Windows.Forms.Panel();
            this.MxLabel1 = new System.Windows.Forms.Label();
            this.StartTime = new System.Windows.Forms.NumericUpDown();
            this.RxLabel2 = new System.Windows.Forms.Label();
            this.WorkTime = new System.Windows.Forms.NumericUpDown();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkTime)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.DeleteButton);
            this.Panel1.Controls.Add(this.AddButton);
            this.Panel1.Controls.Add(this.WorkTime);
            this.Panel1.Controls.Add(this.RxLabel2);
            this.Panel1.Controls.Add(this.StartTime);
            this.Panel1.Controls.Add(this.MxLabel1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(385, 29);
            this.Panel1.TabIndex = 0;
            // 
            // MxLabel1
            // 
            this.MxLabel1.Location = new System.Drawing.Point(2, 8);
            this.MxLabel1.Name = "MxLabel1";
            this.MxLabel1.Size = new System.Drawing.Size(52, 13);
            this.MxLabel1.TabIndex = 0;
            this.MxLabel1.Text = "Start(sec)";
            // 
            // StartTime
            // 
            this.StartTime.DecimalPlaces = 2;
            this.StartTime.Location = new System.Drawing.Point(52, 5);
            this.StartTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(101, 20);
            this.StartTime.TabIndex = 1;
            this.StartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RxLabel2
            // 
            this.RxLabel2.Location = new System.Drawing.Point(153, 8);
            this.RxLabel2.Name = "RxLabel2";
            this.RxLabel2.Size = new System.Drawing.Size(63, 13);
            this.RxLabel2.TabIndex = 2;
            this.RxLabel2.Text = "Length(sec)";
            // 
            // WorkTime
            // 
            this.WorkTime.DecimalPlaces = 2;
            this.WorkTime.Location = new System.Drawing.Point(215, 5);
            this.WorkTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.WorkTime.Name = "WorkTime";
            this.WorkTime.Size = new System.Drawing.Size(101, 20);
            this.WorkTime.TabIndex = 3;
            this.WorkTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(334, 4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(23, 22);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(359, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(23, 22);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "-";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // frmTimeConstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 29);
            this.Controls.Add(this.Panel1);
            this.Name = "frmTimeConstructor";
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StartTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.NumericUpDown WorkTime;
        private System.Windows.Forms.Label RxLabel2;
        private System.Windows.Forms.NumericUpDown StartTime;
        private System.Windows.Forms.Label MxLabel1;
    }
}