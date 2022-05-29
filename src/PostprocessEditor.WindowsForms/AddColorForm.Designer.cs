namespace PostprocessEditor.WindowsForms
{
    partial class AddColorForm
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Color = new System.Windows.Forms.Button();
            this.IntensityValue = new System.Windows.Forms.NumericUpDown();
            this.labelIntensity = new System.Windows.Forms.Label();
            this.BlueValue = new System.Windows.Forms.NumericUpDown();
            this.RxLabel10 = new System.Windows.Forms.Label();
            this.GreenValue = new System.Windows.Forms.NumericUpDown();
            this.RxLabel6 = new System.Windows.Forms.Label();
            this.RedValue = new System.Windows.Forms.NumericUpDown();
            this.RxLabel2 = new System.Windows.Forms.Label();
            this.TimeValue = new System.Windows.Forms.NumericUpDown();
            this.MxLabel1 = new System.Windows.Forms.Label();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntensityValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeValue)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Color);
            this.GroupBox1.Controls.Add(this.IntensityValue);
            this.GroupBox1.Controls.Add(this.labelIntensity);
            this.GroupBox1.Controls.Add(this.BlueValue);
            this.GroupBox1.Controls.Add(this.RxLabel10);
            this.GroupBox1.Controls.Add(this.GreenValue);
            this.GroupBox1.Controls.Add(this.RxLabel6);
            this.GroupBox1.Controls.Add(this.RedValue);
            this.GroupBox1.Controls.Add(this.RxLabel2);
            this.GroupBox1.Controls.Add(this.TimeValue);
            this.GroupBox1.Controls.Add(this.MxLabel1);
            this.GroupBox1.Location = new System.Drawing.Point(4, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(218, 210);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Color";
            // 
            // Color
            // 
            this.Color.Location = new System.Drawing.Point(8, 180);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(37, 21);
            this.Color.TabIndex = 10;
            this.Color.UseVisualStyleBackColor = true;
            this.Color.Click += new System.EventHandler(this.Color_Click);
            // 
            // IntensityValue
            // 
            this.IntensityValue.DecimalPlaces = 2;
            this.IntensityValue.Location = new System.Drawing.Point(115, 144);
            this.IntensityValue.Name = "IntensityValue";
            this.IntensityValue.Size = new System.Drawing.Size(93, 27);
            this.IntensityValue.TabIndex = 9;
            this.IntensityValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelIntensity
            // 
            this.labelIntensity.AutoSize = true;
            this.labelIntensity.Location = new System.Drawing.Point(8, 146);
            this.labelIntensity.Name = "labelIntensity";
            this.labelIntensity.Size = new System.Drawing.Size(56, 20);
            this.labelIntensity.TabIndex = 8;
            this.labelIntensity.Text = "Itensity";
            // 
            // BlueValue
            // 
            this.BlueValue.DecimalPlaces = 2;
            this.BlueValue.Location = new System.Drawing.Point(115, 111);
            this.BlueValue.Name = "BlueValue";
            this.BlueValue.Size = new System.Drawing.Size(93, 27);
            this.BlueValue.TabIndex = 7;
            this.BlueValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RxLabel10
            // 
            this.RxLabel10.AutoSize = true;
            this.RxLabel10.ForeColor = System.Drawing.Color.Blue;
            this.RxLabel10.Location = new System.Drawing.Point(8, 113);
            this.RxLabel10.Name = "RxLabel10";
            this.RxLabel10.Size = new System.Drawing.Size(18, 20);
            this.RxLabel10.TabIndex = 6;
            this.RxLabel10.Text = "B";
            // 
            // GreenValue
            // 
            this.GreenValue.DecimalPlaces = 2;
            this.GreenValue.Location = new System.Drawing.Point(115, 85);
            this.GreenValue.Name = "GreenValue";
            this.GreenValue.Size = new System.Drawing.Size(93, 27);
            this.GreenValue.TabIndex = 5;
            this.GreenValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RxLabel6
            // 
            this.RxLabel6.AutoSize = true;
            this.RxLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.RxLabel6.Location = new System.Drawing.Point(8, 87);
            this.RxLabel6.Name = "RxLabel6";
            this.RxLabel6.Size = new System.Drawing.Size(19, 20);
            this.RxLabel6.TabIndex = 4;
            this.RxLabel6.Text = "G";
            // 
            // RedValue
            // 
            this.RedValue.DecimalPlaces = 2;
            this.RedValue.Location = new System.Drawing.Point(115, 59);
            this.RedValue.Name = "RedValue";
            this.RedValue.Size = new System.Drawing.Size(93, 27);
            this.RedValue.TabIndex = 3;
            this.RedValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RxLabel2
            // 
            this.RxLabel2.AutoSize = true;
            this.RxLabel2.ForeColor = System.Drawing.Color.Red;
            this.RxLabel2.Location = new System.Drawing.Point(8, 61);
            this.RxLabel2.Name = "RxLabel2";
            this.RxLabel2.Size = new System.Drawing.Size(18, 20);
            this.RxLabel2.TabIndex = 2;
            this.RxLabel2.Text = "R";
            // 
            // TimeValue
            // 
            this.TimeValue.DecimalPlaces = 2;
            this.TimeValue.Location = new System.Drawing.Point(115, 26);
            this.TimeValue.Name = "TimeValue";
            this.TimeValue.Size = new System.Drawing.Size(93, 27);
            this.TimeValue.TabIndex = 1;
            this.TimeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MxLabel1
            // 
            this.MxLabel1.AutoSize = true;
            this.MxLabel1.Location = new System.Drawing.Point(8, 28);
            this.MxLabel1.Name = "MxLabel1";
            this.MxLabel1.Size = new System.Drawing.Size(101, 20);
            this.MxLabel1.TabIndex = 0;
            this.MxLabel1.Text = "Key Time(sec)";
            // 
            // ColorDialog
            // 
            this.ColorDialog.FullOpen = true;
            this.ColorDialog.SolidColorOnly = true;
            // 
            // AddColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 219);
            this.Controls.Add(this.GroupBox1);
            this.Name = "AddColorForm";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntensityValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.NumericUpDown RedValue;
        private System.Windows.Forms.Label RxLabel2;
        private System.Windows.Forms.NumericUpDown TimeValue;
        private System.Windows.Forms.Label MxLabel1;
        private System.Windows.Forms.Label RxLabel6;
        private System.Windows.Forms.NumericUpDown GreenValue;
        private System.Windows.Forms.NumericUpDown BlueValue;
        private System.Windows.Forms.Label RxLabel10;
        private System.Windows.Forms.Button Color;
        private System.Windows.Forms.NumericUpDown IntensityValue;
        private System.Windows.Forms.Label labelIntensity;
        private System.Windows.Forms.ColorDialog ColorDialog;
    }
}
