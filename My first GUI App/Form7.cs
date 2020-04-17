using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Reflection;

namespace My_first_GUI_App
{
    public partial class frmImage : Form
    {
        Assembly _assembly; //creating an assembly object
        Stream _imageStream; //creating an imagestream object
        public frmImage()
        {
            InitializeComponent();
        }

        private void BtnLoadImage_Click(object sender, EventArgs e)
        {
            try
            {
                picTry.Image=Image.FromFile("C:\\Users\\salem\\Pictures\\Salem.JPEG");
            }
            catch
            {
                MessageBox.Show("Image file not found");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void picTry_Click(object sender, EventArgs e)
        {

        }

        private void frmImage_Load(object sender, EventArgs e)
        {
            _assembly = Assembly.GetExecutingAssembly();
            _imageStream = _assembly.GetManifestResourceStream("My_first_GUI_App.res.Salem.jpeg");
        }

        private void LoadFromSource_Click(object sender, EventArgs e)
        {
            try
            {
                picTry2.Image = Image.FromStream(_imageStream);
            }
            catch
            {
                MessageBox.Show("Error creating image from source");
            }
        }
    }
}
