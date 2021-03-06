namespace PostprocessEditor.WindowsForms
{
    partial class AddFloatForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmTextureName = new System.Windows.Forms.TextBox();
            this.Value3 = new System.Windows.Forms.NumericUpDown();
            this.Label3 = new System.Windows.Forms.Label();
            this.Value2 = new System.Windows.Forms.NumericUpDown();
            this.Label2 = new System.Windows.Forms.Label();
            this.Value1 = new System.Windows.Forms.NumericUpDown();
            this.Label1 = new System.Windows.Forms.Label();
            this.TimeValue = new System.Windows.Forms.NumericUpDown();
            this.MxLabel1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Value3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeValue)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmTextureName);
            this.groupBox1.Controls.Add(this.Value3);
            this.groupBox1.Controls.Add(this.Label3);
            this.groupBox1.Controls.Add(this.Value2);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.Value1);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Controls.Add(this.TimeValue);
            this.groupBox1.Controls.Add(this.MxLabel1);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Node data";
            // 
            // cmTextureName
            // 
            this.cmTextureName.Location = new System.Drawing.Point(8, 144);
            this.cmTextureName.Name = "cmTextureName";
            this.cmTextureName.Size = new System.Drawing.Size(169, 27);
            this.cmTextureName.TabIndex = 8;
            this.cmTextureName.Text = "cmTextureName";
            // 
            // Value3
            // 
            this.Value3.DecimalPlaces = 2;
            this.Value3.Location = new System.Drawing.Point(115, 111);
            this.Value3.Name = "Value3";
            this.Value3.Size = new System.Drawing.Size(93, 27);
            this.Value3.TabIndex = 7;
            this.Value3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.ForeColor = System.Drawing.Color.Blue;
            this.Label3.Location = new System.Drawing.Point(8, 113);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(45, 20);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "Value";
            // 
            // Value2
            // 
            this.Value2.DecimalPlaces = 2;
            this.Value2.Location = new System.Drawing.Point(115, 85);
            this.Value2.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Value2.Name = "Value2";
            this.Value2.Size = new System.Drawing.Size(93, 27);
            this.Value2.TabIndex = 5;
            this.Value2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.Label2.Location = new System.Drawing.Point(8, 87);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(45, 20);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Value";
            // 
            // Value1
            // 
            this.Value1.DecimalPlaces = 2;
            this.Value1.Location = new System.Drawing.Point(115, 59);
            this.Value1.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Value1.Name = "Value1";
            this.Value1.Size = new System.Drawing.Size(93, 27);
            this.Value1.TabIndex = 3;
            this.Value1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.ForeColor = System.Drawing.Color.Red;
            this.Label1.Location = new System.Drawing.Point(8, 61);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(45, 20);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Value";
            // 
            // TimeValue
            // 
            this.TimeValue.DecimalPlaces = 2;
            this.TimeValue.Location = new System.Drawing.Point(115, 26);
            this.TimeValue.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
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
            // AddFloatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 188);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddFloatForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Value3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label MxLabel1;
        private System.Windows.Forms.TextBox cmTextureName;
        private System.Windows.Forms.NumericUpDown Value3;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.NumericUpDown Value2;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.NumericUpDown Value1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.NumericUpDown TimeValue;
    }
}
