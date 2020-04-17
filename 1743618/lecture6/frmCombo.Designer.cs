namespace lecture6
{
    partial class FrmCombo
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
            this.BtnRemoveIndex = new System.Windows.Forms.Button();
            this.BtnSSM2 = new System.Windows.Forms.Button();
            this.BtnSSM1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.BtnRemoveLast = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.CmbDays = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSSM3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnRemoveIndex
            // 
            this.BtnRemoveIndex.BackColor = System.Drawing.Color.Gray;
            this.BtnRemoveIndex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRemoveIndex.ForeColor = System.Drawing.Color.White;
            this.BtnRemoveIndex.Location = new System.Drawing.Point(17, 121);
            this.BtnRemoveIndex.Name = "BtnRemoveIndex";
            this.BtnRemoveIndex.Size = new System.Drawing.Size(121, 44);
            this.BtnRemoveIndex.TabIndex = 0;
            this.BtnRemoveIndex.Text = "Remove by Index";
            this.BtnRemoveIndex.UseVisualStyleBackColor = false;
            this.BtnRemoveIndex.Click += new System.EventHandler(this.BtnRemoveIndex_Click);
            // 
            // BtnSSM2
            // 
            this.BtnSSM2.BackColor = System.Drawing.Color.Gray;
            this.BtnSSM2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSSM2.ForeColor = System.Drawing.Color.White;
            this.BtnSSM2.Location = new System.Drawing.Point(271, 71);
            this.BtnSSM2.Name = "BtnSSM2";
            this.BtnSSM2.Size = new System.Drawing.Size(121, 44);
            this.BtnSSM2.TabIndex = 1;
            this.BtnSSM2.Text = "Show Selected Method 2";
            this.BtnSSM2.UseVisualStyleBackColor = false;
            this.BtnSSM2.Click += new System.EventHandler(this.BtnSSM2_Click);
            // 
            // BtnSSM1
            // 
            this.BtnSSM1.BackColor = System.Drawing.Color.Gray;
            this.BtnSSM1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSSM1.ForeColor = System.Drawing.Color.White;
            this.BtnSSM1.Location = new System.Drawing.Point(271, 21);
            this.BtnSSM1.Name = "BtnSSM1";
            this.BtnSSM1.Size = new System.Drawing.Size(121, 44);
            this.BtnSSM1.TabIndex = 3;
            this.BtnSSM1.Text = "Show Selected Method 1";
            this.BtnSSM1.UseVisualStyleBackColor = false;
            this.BtnSSM1.Click += new System.EventHandler(this.BtnSSM1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(144, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 44);
            this.button4.TabIndex = 2;
            this.button4.Text = "Remove 2nd last item";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // BtnRemoveLast
            // 
            this.BtnRemoveLast.BackColor = System.Drawing.Color.Gray;
            this.BtnRemoveLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRemoveLast.ForeColor = System.Drawing.Color.White;
            this.BtnRemoveLast.Location = new System.Drawing.Point(17, 21);
            this.BtnRemoveLast.Name = "BtnRemoveLast";
            this.BtnRemoveLast.Size = new System.Drawing.Size(121, 44);
            this.BtnRemoveLast.TabIndex = 4;
            this.BtnRemoveLast.Text = "Remove last item";
            this.BtnRemoveLast.UseVisualStyleBackColor = false;
            this.BtnRemoveLast.Click += new System.EventHandler(this.BtnRemoveLast_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gray;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(144, 121);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 44);
            this.button6.TabIndex = 5;
            this.button6.Text = "Remove by Name";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Gray;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(17, 171);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(375, 44);
            this.button7.TabIndex = 6;
            this.button7.Text = "Back";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // CmbDays
            // 
            this.CmbDays.FormattingEnabled = true;
            this.CmbDays.Location = new System.Drawing.Point(17, 82);
            this.CmbDays.Name = "CmbDays";
            this.CmbDays.Size = new System.Drawing.Size(248, 24);
            this.CmbDays.TabIndex = 7;
            this.CmbDays.SelectedIndexChanged += new System.EventHandler(this.CmbDays_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnSSM3);
            this.groupBox1.Controls.Add(this.BtnSSM2);
            this.groupBox1.Controls.Add(this.CmbDays);
            this.groupBox1.Controls.Add(this.BtnRemoveIndex);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.BtnSSM1);
            this.groupBox1.Controls.Add(this.BtnRemoveLast);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 235);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Choose the Combo ";
            // 
            // BtnSSM3
            // 
            this.BtnSSM3.BackColor = System.Drawing.Color.Gray;
            this.BtnSSM3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSSM3.ForeColor = System.Drawing.Color.White;
            this.BtnSSM3.Location = new System.Drawing.Point(271, 121);
            this.BtnSSM3.Name = "BtnSSM3";
            this.BtnSSM3.Size = new System.Drawing.Size(121, 44);
            this.BtnSSM3.TabIndex = 8;
            this.BtnSSM3.Text = "Show Selected Method 3";
            this.BtnSSM3.UseVisualStyleBackColor = false;
            this.BtnSSM3.Click += new System.EventHandler(this.BtnSSM3_Click);
            // 
            // FrmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(430, 307);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCombo";
            this.Text = "Combo";
            this.Load += new System.EventHandler(this.FrmCombo_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRemoveIndex;
        private System.Windows.Forms.Button BtnSSM2;
        private System.Windows.Forms.Button BtnSSM1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BtnRemoveLast;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox CmbDays;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSSM3;
    }
}