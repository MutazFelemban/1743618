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
    public partial class frmMain : Form
    {
       
        public frmMain()
        {
            InitializeComponent();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUser.Text == "T4Z" && TxtPW.Text == "Aa11")
            {
                MessageBox.Show("Login Successful!");
            }
            else if (TxtUser.Text!= "T4Z" && TxtPW.Text !="Aa11")
            {
                MessageBox.Show("Invalid Username and Password");
            }
            else if(TxtPW.Text!="Aa11")
            {
                MessageBox.Show("Invalid Password");
            }
            else
            {
                MessageBox.Show("Invalid Username ");
            }
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {

        }

        private void TxtPW_TextChanged(object sender, EventArgs e)
        {
            TxtPW.PasswordChar = '*';
        }

        private void FrmRadio_Click(object sender, EventArgs e)
        {
            FrmRadio frm = new FrmRadio();
            frm.ShowDialog();

        }

        private void FrmChk_Click(object sender, EventArgs e)
        {
            FrmChk frm = new FrmChk();
            frm.ShowDialog();
        }

        private void FrmCombo_Click(object sender, EventArgs e)
        {
            FrmCombo frm = new FrmCombo();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmRandom frm = new FrmRandom();
            frm.ShowDialog();
        }

        private void btnRandomCombo_Click(object sender, EventArgs e)
        {
            frmRandomCombo frm = new frmRandomCombo();
            frm.ShowDialog();
        }

        private void btnPicBox_Click(object sender, EventArgs e)
        {
            FrmPic frm = new FrmPic();
            frm.ShowDialog();
        }

        private void btnPicBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
