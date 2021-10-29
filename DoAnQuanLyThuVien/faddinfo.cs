using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
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

        public int Add()
        {
            if (txtUserName.Text == "")
                return 0;

            LIBRARY_DATABASEEntities db = new LIBRARY_DATABASEEntities();

            string usname = txtUserName.Text;
            string pass = txtPassWord.Text;
            string LName = txtLastName.Text;
            string FName = txtFirstName.Text;
            string gt = txtGender.Text;
            DateTime ngaysinh = dtpkBirthDate.Value;
            System.Byte tuoi = Convert.ToByte(DateTime.Now.Year - ngaysinh.Year);
            string diachi = txtAddress.Text;
            string sdt = txtPhoneNumber.Text;
            string mail = txtEmail.Text;
            bool type = Convert.ToBoolean(nudType.Value);
            string luuy = txtNote.Text;

            //STAFF_ACCOUNT obj = new STAFF_ACCOUNT(usname, pass, LName, FName, gt, ngaysinh, tuoi, diachi, sdt, mail, type, luuy);

            STAFF_ACCOUNT obj = new STAFF_ACCOUNT();

            obj.USERNAME = usname;
            obj.PASSWORD = pass;
            obj.LAST_NAME = LName;
            obj.FIRST_NAME = FName;
            obj.GENDER = gt;
            obj.BIRTHDATE = ngaysinh;
            obj.AGE = tuoi;
            obj.ADDRESS = diachi;
            obj.PHONE_NUMBER = sdt;
            obj.EMAIL = mail;
            obj.TYPE = type;
            obj.NOTE = luuy;

            db.STAFF_ACCOUNT.Add(obj);
            return db.SaveChanges();
        }

        void AddAccount(/*string name, string LName, string FName, string gt, string ngaysinh, int tuoi, string diachi, string sdt, string mail, int type, string luuy*/)
        {
            //if (AccountDAO.Instance.InsertAccount(name, LName, FName, gt, ngaysinh, tuoi, diachi, sdt, mail, type, luuy))
            if (Add() == 1)
            {
                DialogResult OK = MessageBox.Show("Thêm Tài khoản thành công.", "Thông báo", MessageBoxButtons.OK);
                txtUserName.Clear();
                txtPassWord.Clear();
                txtLastName.Clear();
                txtFirstName.Clear();
                txtGender.ResetText();
                dtpkBirthDate.ResetText();
                txtAddress.Clear() ;
                txtPhoneNumber.Clear();
                txtEmail.Clear();
                nudType.ResetText();
                txtNote.Clear();
            }
            else
            {
                DialogResult OK = MessageBox.Show("Thêm Tài khoản thất bại, hãy điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK);
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
            AddAccount();
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
