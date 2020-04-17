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
    public partial class FrmCombo : Form
    {
        public FrmCombo()
        {
            
            InitializeComponent();
            
            // Adding items to the Combo Box.
            CmbDays.Items.Add("Sunday");
            CmbDays.Items.Add("Monday");
            CmbDays.Items.Add("Tuesday");
            CmbDays.Items.Add("Wednesday");
            CmbDays.Items.Add("Thursday");
            CmbDays.Items.Add("Friday");
            CmbDays.Items.Add("Saturday");
            CmbDays.Items.Add("Fun Day");
            CmbDays.Items.Add("Exam Day");


        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void FrmCombo_Load(object sender, EventArgs e)
        {

        }

        private void CmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnSSM1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CmbDays.Text);
        }

        private void BtnSSM3_Click(object sender, EventArgs e)
        {
            var item = CmbDays.SelectedItem;
            if (item != null)
                MessageBox.Show(item.ToString());
        }

        private void BtnSSM2_Click(object sender, EventArgs e)
        {
            string itemText = CmbDays.GetItemText(CmbDays.SelectedItem);
            MessageBox.Show(itemText);
        }

        private void BtnRemoveIndex_Click(object sender, EventArgs e)
        {
             //remove item 
            CmbDays.Items.RemoveAt(1);
            //above code will remove the second item first
        }

        private void BtnRemoveLast_Click(object sender, EventArgs e)
        {
            if (CmbDays.Items.Count >= 1)
            {
                CmbDays.Items.RemoveAt(CmbDays.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("Cannot Remove the last item");
            }
        }
    }
}
