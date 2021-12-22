using DoAnQuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLyThuVien
{
    public partial class fnewAccount : Form
    {
        private SHARED_LIBRARY_ENTITY dataBase = new SHARED_LIBRARY_ENTITY();
        private bool isStaff;

        public fnewAccount(bool _isStaff)
        {
            InitializeComponent();

            set_formIcon(_isStaff);

            isStaff = _isStaff;   
        }



        //---Controls_Events---
        #region ===============Controls_Events===============

        private void button_signIn_Click(object sender, EventArgs e)
        {
            newAccount_signIn();
        }

        #endregion ==========================================

        //---Funcs_&_Procs---
        #region ================Funcs_&_Procs================

        private void set_formIcon(bool _isStaff)
        {
            Bitmap formIcon;

            if (_isStaff)
            {
                formIcon = new Bitmap(global::DoAnQuanLyThuVien.Properties.Resources.librarian_2);
                Text = "Nhân viên mới";
            }
            else
            {
                formIcon = new Bitmap(global::DoAnQuanLyThuVien.Properties.Resources.reader);
                Text = "Người đọc mới";
            }

            panel_Icon.BackgroundImage = formIcon;
        }

        private bool is_dataErrors(string _userName, string _passWord, string _rePass)
        {
            if (_userName == "")
            {
                DialogResult empty_Username = MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return true;
            }

            if (_passWord != _rePass)
            {
                DialogResult unmatched_Password = MessageBox.Show("Mật khẩu không trùng khớp!");
                return true;
            }

            return false;
        }

        private string Encrypt_Password()
        {
            byte[] password_byteArray = ASCIIEncoding.ASCII.GetBytes(PASSWORDTextEdit.Text);

            byte[] byte_hashedPassword = new MD5CryptoServiceProvider().ComputeHash(password_byteArray);

            string str_hashedPassword = "";

            foreach (byte item in byte_hashedPassword)
            {
                str_hashedPassword += item;
            }

            return str_hashedPassword;
        }

        private void newAccount_signIn()
        {
            string name = NAMEtextEdit.Text == "" ? "Unnamed User" : NAMEtextEdit.Text;
            string reEnter_Password = REPASStextEdit.Text;
            string userName = USERNAMETextEdit.Text;
            string passWord = PASSWORDTextEdit.Text;

            if (is_dataErrors(userName, passWord, reEnter_Password))
                return;

            try
            {
                string encryptedPassword = Encrypt_Password();

                newAccount_signIn(userName, encryptedPassword, name);
            }
            catch
            {
                DialogResult duplicated_Username = MessageBox.Show("Tài khoản đã tồn tại!");
            }
        }

        private void newAccount_signIn(string _userName, string _encryptedPassword, string _name)
        {
            if (isStaff)
            {
                var item = new STAFF_INF(_userName, _encryptedPassword, _name);

                dataBase.STAFF_INF.Add(item);
            }
            else
            {
                var item = new READER_INF(_userName, _encryptedPassword, _name);

                dataBase.READER_INF.Add(item);
            }

            dataBase.SaveChanges();

            DialogResult successfully_Create_newAccount = MessageBox.Show("Tạo tài khoản mới thành công!");

            this.Close();
        }

        #endregion ==========================================
    }
}
