using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using DevExpress.XtraEditors;
using ZXing;

namespace DoAnQuanLyThuVien
{
    public partial class fScanner : DevExpress.XtraEditors.XtraForm
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        static int id;
        public fScanner()
        {
            InitializeComponent();
        }

        public int Id()
        {
            return id;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void fScanner_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (filterInfoCollection.Count == 0)
            {
                return;
            }
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[0].MonikerString);
            videoCaptureDevice.NewFrame += videoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();

        }

        private void videoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            
            try
            {
                Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
                BarcodeReader reader = new BarcodeReader();
                var result = reader.Decode(bitmap);
                if (result != null)
                {
                    id = int.Parse(result.ToString());
                    MessageBox.Show("Đã nhận được mã vạch!!!");

                }
                pictureBox1.Image = bitmap;
            }
            catch
            {
                MessageBox.Show("Chưa thể nhận dạng được mã sách");
            }
            

        }
    }
}