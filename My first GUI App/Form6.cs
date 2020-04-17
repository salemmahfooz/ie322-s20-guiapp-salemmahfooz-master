using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_first_GUI_App
{
    public partial class FrmRandomCombo : Form
    {
        public FrmRandomCombo()
        {
            InitializeComponent();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            cmbRandom.ResetText();
            cmbRandom.Items.Clear();
            Random r = new Random();
            for (int i = 0; i < r.Next(1, 50) - 1; i++)
            {
                cmbRandom.Items.Add(r.Next(100, 999));
            }
        }

        private void FrmRandomCombo_Load(object sender, EventArgs e)
        {

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            cmbRandom.ResetText();
            cmbRandom.Items.Clear();
            RdoLessthan500.Checked = false;
            RdoGreaterthan50.Checked = false;
            
        }

        private void cmbRandom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Convert.ToInt32(cmbRandom.Text)>499)
            {
                RdoGreaterthan500.Checked = true;
            }
            else
            {
                RdoLessthan500.Checked = true;
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;

        }

        private void BtnGenerate1_Click(object sender, EventArgs e)
        {
            cmbrandom1.ResetText();
            cmbrandom1.Items.Clear();
            Random r = new Random();
            for(int i=0;i<r.Next(2,9)-1;i++)
            {
                cmbrandom1.Items.Add(r.Next(10, 99));
            }
            label1.Text = Convert.ToString(cmbrandom1.Items.Count);
        }

        private void cmbrandom1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbrandom1.Text) > 49)
            {
                RdoGreaterthan50.Checked = true;
            }
            else
            {
                RdoLessthan50.Checked = true;
            }
        }

        private void BtnReset1_Click(object sender, EventArgs e)
        {
            cmbrandom1.ResetText();
            cmbrandom1.Items.Clear();
            RdoLessthan50.Checked = false;
            RdoGreaterthan50.Checked = false;
            label1.Text = Convert.ToString(cmbrandom1.Items.Count);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
