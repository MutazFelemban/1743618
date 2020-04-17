namespace lecture6
{
    partial class frmRandomCombo
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
            this.btnGenerate1 = new System.Windows.Forms.Button();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.btnGenerate2 = new System.Windows.Forms.Button();
            this.btnReset1 = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.cmbRandom1 = new System.Windows.Forms.ComboBox();
            this.cmbRandom2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RdoLessThan50 = new System.Windows.Forms.RadioButton();
            this.RdoGreaterThan50 = new System.Windows.Forms.RadioButton();
            this.RdoLessThan500 = new System.Windows.Forms.RadioButton();
            this.RdoGreaterThan500 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnGenerate1
            // 
            this.btnGenerate1.BackColor = System.Drawing.Color.Gray;
            this.btnGenerate1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerate1.ForeColor = System.Drawing.Color.White;
            this.btnGenerate1.Location = new System.Drawing.Point(6, 54);
            this.btnGenerate1.Name = "btnGenerate1";
            this.btnGenerate1.Size = new System.Drawing.Size(121, 23);
            this.btnGenerate1.TabIndex = 0;
            this.btnGenerate1.Text = "Generate";
            this.btnGenerate1.UseVisualStyleBackColor = false;
            this.btnGenerate1.Click += new System.EventHandler(this.btnGenerate1_Click);
            // 
            // btnReset2
            // 
            this.btnReset2.BackColor = System.Drawing.Color.Gray;
            this.btnReset2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset2.ForeColor = System.Drawing.Color.White;
            this.btnReset2.Location = new System.Drawing.Point(187, 167);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(121, 37);
            this.btnReset2.TabIndex = 1;
            this.btnReset2.Text = "Reset";
            this.btnReset2.UseVisualStyleBackColor = false;
            this.btnReset2.Click += new System.EventHandler(this.btnReset2_Click);
            // 
            // btnGenerate2
            // 
            this.btnGenerate2.BackColor = System.Drawing.Color.Gray;
            this.btnGenerate2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerate2.ForeColor = System.Drawing.Color.White;
            this.btnGenerate2.Location = new System.Drawing.Point(187, 54);
            this.btnGenerate2.Name = "btnGenerate2";
            this.btnGenerate2.Size = new System.Drawing.Size(122, 23);
            this.btnGenerate2.TabIndex = 2;
            this.btnGenerate2.Text = "Generate";
            this.btnGenerate2.UseVisualStyleBackColor = false;
            this.btnGenerate2.Click += new System.EventHandler(this.btnGenerate2_Click);
            // 
            // btnReset1
            // 
            this.btnReset1.BackColor = System.Drawing.Color.Gray;
            this.btnReset1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset1.ForeColor = System.Drawing.Color.White;
            this.btnReset1.Location = new System.Drawing.Point(6, 167);
            this.btnReset1.Name = "btnReset1";
            this.btnReset1.Size = new System.Drawing.Size(121, 37);
            this.btnReset1.TabIndex = 3;
            this.btnReset1.Text = "Reset";
            this.btnReset1.UseVisualStyleBackColor = false;
            this.btnReset1.Click += new System.EventHandler(this.btnReset1_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.Gray;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(114, 220);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(96, 43);
            this.BtnBack.TabIndex = 4;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // cmbRandom1
            // 
            this.cmbRandom1.FormattingEnabled = true;
            this.cmbRandom1.Location = new System.Drawing.Point(6, 83);
            this.cmbRandom1.Name = "cmbRandom1";
            this.cmbRandom1.Size = new System.Drawing.Size(121, 24);
            this.cmbRandom1.TabIndex = 5;
            // 
            // cmbRandom2
            // 
            this.cmbRandom2.FormattingEnabled = true;
            this.cmbRandom2.Location = new System.Drawing.Point(187, 83);
            this.cmbRandom2.Name = "cmbRandom2";
            this.cmbRandom2.Size = new System.Drawing.Size(121, 24);
            this.cmbRandom2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quiz03_AAF19";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(199, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Quiz03_EAF19";
            // 
            // RdoLessThan50
            // 
            this.RdoLessThan50.AutoSize = true;
            this.RdoLessThan50.ForeColor = System.Drawing.Color.White;
            this.RdoLessThan50.Location = new System.Drawing.Point(187, 113);
            this.RdoLessThan50.Name = "RdoLessThan50";
            this.RdoLessThan50.Size = new System.Drawing.Size(111, 21);
            this.RdoLessThan50.TabIndex = 9;
            this.RdoLessThan50.TabStop = true;
            this.RdoLessThan50.Text = "Less than 50";
            this.RdoLessThan50.UseVisualStyleBackColor = true;
            // 
            // RdoGreaterThan50
            // 
            this.RdoGreaterThan50.AutoSize = true;
            this.RdoGreaterThan50.ForeColor = System.Drawing.Color.White;
            this.RdoGreaterThan50.Location = new System.Drawing.Point(187, 140);
            this.RdoGreaterThan50.Name = "RdoGreaterThan50";
            this.RdoGreaterThan50.Size = new System.Drawing.Size(130, 21);
            this.RdoGreaterThan50.TabIndex = 10;
            this.RdoGreaterThan50.TabStop = true;
            this.RdoGreaterThan50.Text = "Greater than 50";
            this.RdoGreaterThan50.UseVisualStyleBackColor = true;
            // 
            // RdoLessThan500
            // 
            this.RdoLessThan500.AutoSize = true;
            this.RdoLessThan500.ForeColor = System.Drawing.Color.White;
            this.RdoLessThan500.Location = new System.Drawing.Point(6, 113);
            this.RdoLessThan500.Name = "RdoLessThan500";
            this.RdoLessThan500.Size = new System.Drawing.Size(119, 21);
            this.RdoLessThan500.TabIndex = 11;
            this.RdoLessThan500.TabStop = true;
            this.RdoLessThan500.Text = "Less than 500";
            this.RdoLessThan500.UseVisualStyleBackColor = true;
            // 
            // RdoGreaterThan500
            // 
            this.RdoGreaterThan500.AutoSize = true;
            this.RdoGreaterThan500.ForeColor = System.Drawing.Color.White;
            this.RdoGreaterThan500.Location = new System.Drawing.Point(6, 140);
            this.RdoGreaterThan500.Name = "RdoGreaterThan500";
            this.RdoGreaterThan500.Size = new System.Drawing.Size(138, 21);
            this.RdoGreaterThan500.TabIndex = 12;
            this.RdoGreaterThan500.TabStop = true;
            this.RdoGreaterThan500.Text = "Greater than 500";
            this.RdoGreaterThan500.UseVisualStyleBackColor = true;
            // 
            // frmRandomCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(362, 275);
            this.Controls.Add(this.RdoGreaterThan500);
            this.Controls.Add(this.RdoLessThan500);
            this.Controls.Add(this.RdoGreaterThan50);
            this.Controls.Add(this.RdoLessThan50);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRandom2);
            this.Controls.Add(this.cmbRandom1);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.btnReset1);
            this.Controls.Add(this.btnGenerate2);
            this.Controls.Add(this.btnReset2);
            this.Controls.Add(this.btnGenerate1);
            this.Name = "frmRandomCombo";
            this.Text = "frmRandomCombo";
            this.Load += new System.EventHandler(this.frmRandomCombo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate1;
        private System.Windows.Forms.Button btnReset2;
        private System.Windows.Forms.Button btnGenerate2;
        private System.Windows.Forms.Button btnReset1;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.ComboBox cmbRandom1;
        private System.Windows.Forms.ComboBox cmbRandom2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RdoLessThan50;
        private System.Windows.Forms.RadioButton RdoGreaterThan50;
        private System.Windows.Forms.RadioButton RdoLessThan500;
        private System.Windows.Forms.RadioButton RdoGreaterThan500;
    }
}