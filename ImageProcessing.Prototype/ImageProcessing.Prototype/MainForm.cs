using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing.Prototype
{
    public partial class MainForm : Form
    {
        private OpenFileDialog ofd;
        private SaveFileDialog sfd;

        public MainForm()
        {
            InitializeComponent();

            ofd = new OpenFileDialog()
            {
                Title = $"{Name}: Open File Dialog",
                Filter = "Image Files (*.BMP;*JPG;*.PNG)|*.BMP;*.PNG;*JPG",
                CheckFileExists = true,

            };
            sfd = new SaveFileDialog()
            {
                Title = $"{Name}: Save File Dialog",
                Filter = "Image Files (*.BMP;*JPG;*.PNG)|*.BMP;*.PNG;*JPG",
                CheckFileExists = true,
            };

        }



        private void btnOpenImageEditor_Click(object sender, EventArgs e)
        {
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {


                string FileName = ofd.FileName;

            }
        }

        private void btnOpenPicSew_Click(object sender, EventArgs e)
        {
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {


                string[] FileNames = ofd.FileNames;

            }
        }
    }
}
