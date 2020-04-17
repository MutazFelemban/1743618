using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO; //for stream object
using System.Reflection; // for assembly

namespace lecture6
{
    public partial class FrmPic : Form
    {
        Assembly _assembly; // Creating an assembly object
        Stream _imageStream; // Creating an imagestream object 



        public FrmPic()
        {
            InitializeComponent();
        }

        private void BtnFrmFile_Click(object sender, EventArgs e)
        {
            try
            {
                PicTry1.Image = Image.FromFile("D:/sar3.png");
            }
            catch
            {
                MessageBox.Show("NF");
            }
        }

        private void PicTry1_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnBack6_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnFrmResource_Click(object sender, EventArgs e)
        {
            try
            {

                PicTry2.Image = Image.FromStream(_imageStream);

            }
            catch
            {
                MessageBox.Show("Error creating image!");
            }
        }

        private void FrmPic_Load(object sender, EventArgs e)
        {
            _assembly = Assembly.GetExecutingAssembly(); //set the assembly object 
            _imageStream = _assembly.GetManifestResourceStream("lecture6.res.Sar2.png");
        }
    }
}
