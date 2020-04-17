namespace lecture6
{
    partial class FrmPic
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
            this.BtnFrmFile = new System.Windows.Forms.Button();
            this.BtnFrmResource = new System.Windows.Forms.Button();
            this.PicTry1 = new System.Windows.Forms.PictureBox();
            this.PicTry2 = new System.Windows.Forms.PictureBox();
            this.BtnBack6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicTry1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTry2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnFrmFile
            // 
            this.BtnFrmFile.BackColor = System.Drawing.Color.Gray;
            this.BtnFrmFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFrmFile.ForeColor = System.Drawing.Color.White;
            this.BtnFrmFile.Location = new System.Drawing.Point(12, 22);
            this.BtnFrmFile.Name = "BtnFrmFile";
            this.BtnFrmFile.Size = new System.Drawing.Size(179, 51);
            this.BtnFrmFile.TabIndex = 0;
            this.BtnFrmFile.Text = "Image from File";
            this.BtnFrmFile.UseVisualStyleBackColor = false;
            this.BtnFrmFile.Click += new System.EventHandler(this.BtnFrmFile_Click);
            // 
            // BtnFrmResource
            // 
            this.BtnFrmResource.BackColor = System.Drawing.Color.Gray;
            this.BtnFrmResource.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFrmResource.ForeColor = System.Drawing.Color.White;
            this.BtnFrmResource.Location = new System.Drawing.Point(12, 79);
            this.BtnFrmResource.Name = "BtnFrmResource";
            this.BtnFrmResource.Size = new System.Drawing.Size(179, 51);
            this.BtnFrmResource.TabIndex = 1;
            this.BtnFrmResource.Text = "Image from Resource";
            this.BtnFrmResource.UseVisualStyleBackColor = false;
            this.BtnFrmResource.Click += new System.EventHandler(this.BtnFrmResource_Click);
            // 
            // PicTry1
            // 
            this.PicTry1.Location = new System.Drawing.Point(216, 22);
            this.PicTry1.Name = "PicTry1";
            this.PicTry1.Size = new System.Drawing.Size(239, 292);
            this.PicTry1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicTry1.TabIndex = 2;
            this.PicTry1.TabStop = false;
            this.PicTry1.Click += new System.EventHandler(this.PicTry1_Click);
            // 
            // PicTry2
            // 
            this.PicTry2.Location = new System.Drawing.Point(473, 22);
            this.PicTry2.Name = "PicTry2";
            this.PicTry2.Size = new System.Drawing.Size(239, 292);
            this.PicTry2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicTry2.TabIndex = 3;
            this.PicTry2.TabStop = false;
            // 
            // BtnBack6
            // 
            this.BtnBack6.BackColor = System.Drawing.Color.Gray;
            this.BtnBack6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBack6.ForeColor = System.Drawing.Color.White;
            this.BtnBack6.Location = new System.Drawing.Point(12, 263);
            this.BtnBack6.Name = "BtnBack6";
            this.BtnBack6.Size = new System.Drawing.Size(179, 51);
            this.BtnBack6.TabIndex = 4;
            this.BtnBack6.Text = "Back";
            this.BtnBack6.UseVisualStyleBackColor = false;
            this.BtnBack6.Click += new System.EventHandler(this.BtnBack6_Click);
            // 
            // FrmPic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(736, 327);
            this.Controls.Add(this.BtnBack6);
            this.Controls.Add(this.PicTry2);
            this.Controls.Add(this.PicTry1);
            this.Controls.Add(this.BtnFrmResource);
            this.Controls.Add(this.BtnFrmFile);
            this.Name = "FrmPic";
            this.Text = "Image";
            this.Load += new System.EventHandler(this.FrmPic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicTry1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTry2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnFrmFile;
        private System.Windows.Forms.Button BtnFrmResource;
        private System.Windows.Forms.PictureBox PicTry1;
        private System.Windows.Forms.PictureBox PicTry2;
        private System.Windows.Forms.Button BtnBack6;
    }
}