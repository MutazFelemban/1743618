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
    public partial class FrmRandom : Form
    {
        Random y = new Random();

        public FrmRandom()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BtnRandomNum.Text = Convert.ToString(y.Next(1, 100));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = y.Next(0, 255);
            int g = y.Next(0, 255);
            int b = y.Next(0, 255);

            label1.Text = Convert.ToString(r) + "-" + Convert.ToString(g) + "-" + Convert.ToString(b);
            BtnGenerateRand.BackColor = Color.FromArgb(r, g, b);
        }
    }
}
