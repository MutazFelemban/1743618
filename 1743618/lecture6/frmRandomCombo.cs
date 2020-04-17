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
    public partial class frmRandomCombo : Form
    {
        Random r = new Random();
        public frmRandomCombo()
        {
            InitializeComponent();
        }

        private void btnReset1_Click(object sender, EventArgs e)
        {
            cmbRandom1.ResetText();
            cmbRandom1.Items.Clear();
            RdoLessThan500.Checked = false;
            RdoGreaterThan500.Checked = false;
        }

        private void btnGenerate1_Click(object sender, EventArgs e)
        {
            cmbRandom1.ResetText();
            cmbRandom1.Items.Clear();
            Random r = new Random();
            for (int i = 0; i <r .Next(1, 51); i++)
            {
                cmbRandom1.Items.Add(r.Next(100, 999));
            }

        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            cmbRandom2.ResetText();
            cmbRandom2.Items.Clear();
            RdoGreaterThan500.Checked = false;
            RdoLessThan500.Checked = false;
            cmbRandom2.Items.Clear();
        }

        private void frmRandomCombo_Load(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnGenerate2_Click(object sender, EventArgs e)
        {
            cmbRandom2.ResetText();
            cmbRandom2.Items.Clear();
            Random r = new Random();
            for (int i = 0; i < r.Next(2, 9) - 1; i++)
            {
                cmbRandom2.Items.Add(r.Next(10, 99));
            }
            label1.Text = Convert.ToString(cmbRandom2.Items.Count);
        }
    }
}
