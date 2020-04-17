using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lecture6
{
    public partial class FrmRadio : Form
    {
        public FrmRadio()
        {
            InitializeComponent();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RdoRed_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoRed.Checked == true)
            {
                RdoRed.ForeColor = Color.FromArgb(255, 0, 0);
            }
            else
            {
                RdoRed.ForeColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void RdoGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoGreen.Checked == true)
            {
                RdoGreen.ForeColor = Color.FromName("green");
            }
            else
            {
                RdoGreen.ForeColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void RdoBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoBlue.Checked == true)
            {
                RdoBlue.ForeColor = Color.FromName("blue");
            }
            else
            {
                RdoBlue.ForeColor = Color.FromName("white");
            }
        }

        private void RdoYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoYellow.Checked == true)
            {
                RdoYellow.ForeColor = Color.FromName("Yellow");
            }
            else
            {
                RdoYellow.ForeColor = Color.FromName("white");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           



            RdoYellow.ForeColor = Color.FromName("black");
            RdoRed.ForeColor = Color.FromName("black");
            RdoBlue.ForeColor = Color.FromName("black");
            RdoGreen.ForeColor = Color.FromName("black");
        }
    }
}
