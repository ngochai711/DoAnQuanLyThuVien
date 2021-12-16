using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using DoAnQuanLyThuVien.DAO;
using DoAnQuanLyThuVien.DTO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.CommonDialogs;
using System.IO;

namespace DoAnQuanLyThuVien
{
    public partial class Finfo : DevExpress.XtraEditors.XtraForm
    {
        public Finfo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string username = "anhthy789";
            List<Infomation> ListInfo = InfoDAO.Instance.GetListInfo(username);
            foreach (Infomation item in ListInfo)
            {
                tbxUsername.Text = item.Username.ToString();
                tbxPass.Text = item.Pass.ToString();
                tbxLName.Text = item.Lastname.ToString();
                tbxFName.Text = item.Finame.ToString();
                if (item.Gen.ToString() == "Nữ")
                    radioBtnFemale.Checked = true;
                else if (item.Gen.ToString() == "Nam")
                    radioBtnMale.Checked = true;
                else radioBtnOther.Checked = true;
                dtpBirthDate.Value = item.Bd;
                tbxAddress.Text = item.Address.ToString();
                tbxPhoneNum.Text = item.Phonenumber.ToString();
                tbxEmail.Text = item.Email.ToString();
            }
        }
        void Edit(string Username, string Pass, string LName, string FName, string Newpass, string Gen, DateTime BD, string Address, string SDT, string Email)
        {

            if (!Newpass.Equals(Pass))
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu!", "Thông báo");
            }
            else
            {
                if(InfoDAO.Instance.EditInfo(Username, Pass, LName, FName, Newpass, Gen, BD, Address, SDT, Email))
                {
                    MessageBox.Show("Lưu thông tin thành công", "Thông báo");
                }    
            }    
        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {
            string Username = tbxUsername.Text;
            string Pass = tbxPass.Text;
            string Newpass = tbxNewpass.Text;
            string LName = tbxLName.Text;
            string FName = tbxFName.Text;
            string Gen;
            if (radioBtnFemale.Checked == true) Gen = "Nữ";
            else if (radioBtnMale.Checked == true) Gen = "Nam";
            else Gen = "Khác";
            DateTime BD = dtpBirthDate.Value;
            string Address = tbxAddress.Text;
            string SDT = tbxPhoneNum.Text;
            string Email = tbxEmail.Text;

            Edit(Username, Pass, LName, FName, Newpass, Gen, BD, Address, SDT, Email);
        }
    }
}
