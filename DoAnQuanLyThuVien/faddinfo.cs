using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using BLABLA.DAO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.CommonDialogs;
using System.Data.Entity;
using DoAnQuanLyThuVien.DTO;
using DevExpress.XtraGrid.Views.Base;

namespace DoAnQuanLyThuVien
{
    public partial class faddinfo : DevExpress.XtraEditors.XtraForm
    {
        public faddinfo()
        {
            InitializeComponent();
        }

        void Add()
        {
            
        }

        void AddAccount(string name, string LName, string FName, string gt, string ngaysinh, int tuoi, string diachi, string sdt, string mail, int type, string luuy)
        {
            //if (AccountDAO.Instance.InsertAccount(name, LName, FName, gt, ngaysinh, tuoi, diachi, sdt, mail, type, luuy))
            if (true)
            {
                DialogResult OK = MessageBox.Show("Thêm Tài khoản thành công.", "Thông báo", MessageBoxButtons.OK);
                if (OK == DialogResult.OK)
                    this.Close(); 
            }
            else
            {
                DialogResult OK = MessageBox.Show("Thêm Tài khoản thất bại, hãy điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK);
                if (OK == DialogResult.OK)
                    this.Close();
            }
            //Load Account
        }

        private void Them_Click(object sender, EventArgs e)
        {
            //string name = TK.Text;
            //string LName = Ho.Text;
            //string FName = Ten.Text;
            //string gt = GioiTinh.Text;
            //string ngaysinh = NgaySinh.Value.ToString("mm/dd/yyyy");
            //int tuoi = Convert.ToInt32(Tuoi.Text);
            //string diachi = DiaChi.Text;
            //string sdt = SDT.Text;
            //string mail = Mail.Text;
            //int type = (int)ChucVu.Value;
            //string luuy = NOTE.Text;
            //AddAccount(name, LName, FName, gt, ngaysinh, tuoi, diachi, sdt, mail, type, luuy);
        }

        private void Huy_Click(object sender, EventArgs e)
        {
            DialogResult YESNO = MessageBox.Show("Bạn có thật sự muốn Hủy?", "Thông báo", MessageBoxButtons.YesNo);
            if (YESNO == DialogResult.Yes)
                this.Close();
        }

        //Them anh
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();
            //string file = openFileDialog1.FileName;
            //if (string.IsNullOrEmpty(file))
            //    return;
            //Image myimage = Image.FromFile(openFileDialog1.FileName);
            //pictureBox1.Image = myimage;
        }
    }
}
