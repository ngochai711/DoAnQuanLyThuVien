using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLyThuVien
{
    public partial class fSetting : Form
    {

        public fSetting(fMain _parentForm)
        {
            InitializeComponent();
            parentForm = _parentForm;
        }
        fMain parentForm;
        private void btnBackgroundChanging_Click(object sender, EventArgs e)
        {
            OpenFileDialog _openFileDialog = new OpenFileDialog();
            _openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {

                parentForm.BackgroundImage = new Bitmap(_openFileDialog.FileName);
                Properties.Settings.Default.Save();
                //parentForm.BackgroundImage.Save(_openFileDialog.FileName,System.Drawing.Imaging.ImageFormat.Jpeg);
               
            }
        }

        private void btnPlayListChanging_Click(object sender, EventArgs e)
        {

        }
    }
}
