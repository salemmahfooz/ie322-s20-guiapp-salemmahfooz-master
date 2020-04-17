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
    public partial class frmRadio : Form
    {
        public frmRadio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RdoRed1_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoRed1.Checked == true)
                RdoRed1.ForeColor = Color.FromArgb(255, 0, 0);
            else
                RdoRed1.ForeColor = Color.FromArgb(0, 0, 0);

        }

        private void frmRadio_Load(object sender, EventArgs e)
        {

        }

        private void RdoGreen1_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoGreen1.Checked == true)
                RdoGreen1.ForeColor = Color.FromArgb(0,255,0);
            else
                RdoGreen1.ForeColor = Color.FromArgb(0,0,0);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            RdoRed.Checked = false;
            RdoGreen.Checked = false;
            RdoBlue.Checked = false;
            RdoYellow.Checked = false;

            RdoRed.ForeColor = Color.FromName("Black");
            RdoGreen.ForeColor = Color.FromName("Black");
            RdoBlue.ForeColor = Color.FromName("Black");
            RdoYellow.ForeColor = Color.FromName("Black");

            RdoRed1.Checked = false;
            RdoGreen1.Checked = false;
            RdoYellow1.Checked = false;
            RdoBlue1.Checked = false;

            RdoRed1.ForeColor = Color.FromName("Black");
            RdoGreen1.ForeColor = Color.FromName("Black");
            RdoBlue1.ForeColor = Color.FromName("Black");
            RdoYellow1.ForeColor = Color.FromName("Black");
        }

        private void RdoBlue1_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoBlue1.Checked == true)
                RdoBlue1.ForeColor = Color.FromName("Blue");
            else
                RdoBlue1.ForeColor = Color.FromName("Black");


        }

        private void RdoYellow1_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoYellow1.Checked == true)
                RdoYellow1.ForeColor = Color.FromName("Yellow");
            else
                RdoYellow1.ForeColor = Color.FromName("Black");
        }

        private void RdoRed_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoRed.Checked == true)
                RdoRed.ForeColor = Color.FromName("Red");
            else
                RdoRed.ForeColor = Color.FromName("Black");
        }

        private void RdoGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoGreen.Checked == true)
                RdoGreen.ForeColor = Color.FromName("Green");
            else
                RdoGreen.ForeColor = Color.FromName("Black");
        }

        private void RdoBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoBlue.Checked == true)
                RdoBlue.ForeColor = Color.FromName("Blue");
            else
                RdoBlue.ForeColor = Color.FromName("Black");
        }

        private void RdoYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoYellow.Checked == true)
                RdoYellow.ForeColor = Color.FromName("Yellow");
            else
                RdoYellow.ForeColor = Color.FromName("Black");
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
