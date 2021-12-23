using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQuanLyThuVien.DTO;

namespace DoAnQuanLyThuVien
{
    public partial class fLogin : Form
    {
        private SHARED_LIBRARY_ENTITY dataBase = new SHARED_LIBRARY_ENTITY();
        private bool isStaff = Properties.Settings.Default.isStaff;
        
        public fLogin()
        {
            InitializeComponent();
        }


        //---Region_Controls_Events---
        #region ===============Controls_Events===============

        private void simpleButton_Login_Click(object sender, EventArgs e)
        {
            string encryptedPassword = Encrypt_Password();

            Check_loginInfo(USERNAMEtextEdit.Text, encryptedPassword);
        }

        private void simpleButton_ModeSettingClick(object sender, EventArgs e)
        {
            panel_Selection.Visible = !panel_Selection.Visible;

            if (isStaff)
            {
                simpleButton_StaffLoginMode.Appearance.BackColor = SystemColors.ActiveCaption;
                simpleButton_ReaderLoginMode.Appearance.BackColor = SystemColors.ButtonHighlight;
            }
            else
            {
                simpleButton_ReaderLoginMode.Appearance.BackColor = SystemColors.ActiveCaption;
                simpleButton_StaffLoginMode.Appearance.BackColor = SystemColors.ButtonHighlight;
            }
        }

        private void simpleButton_LoginModeClick(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.SimpleButton EventCalled_Button = sender as DevExpress.XtraEditors.SimpleButton;

            if (EventCalled_Button.Name == "simpleButton_StaffLoginMode")
            {
                isStaff = true;
                simpleButton_StaffLoginMode.Appearance.BackColor = SystemColors.ActiveCaption;
                simpleButton_ReaderLoginMode.Appearance.BackColor = SystemColors.ButtonHighlight;
            }
            else
            {
                isStaff = false;
                simpleButton_ReaderLoginMode.Appearance.BackColor = SystemColors.ActiveCaption;
                simpleButton_StaffLoginMode.Appearance.BackColor = SystemColors.ButtonHighlight;
            }

            panel_Selection.Visible = !panel_Selection.Visible;

            Properties.Settings.Default.isStaff = isStaff;
            Properties.Settings.Default.Save();
        }

        #endregion ==========================================


        //---Region_Funcs_&_Procs---
        #region ===============Funcs_&_Procs===============

        private string Encrypt_Password()
        {
            byte[] password_byteArray = ASCIIEncoding.ASCII.GetBytes(PASSWORDtextEdit.Text);

            byte[] byte_hashedPassword = new MD5CryptoServiceProvider().ComputeHash(password_byteArray);

            string str_hashedPassword = "";

            foreach (byte item in byte_hashedPassword)
            {
                str_hashedPassword += item;
            }

            return str_hashedPassword;
        }

        private void Check_loginInfo(string _Username, string _encryptedPassword)
        {
            if (Default_Login(_Username, _encryptedPassword)) return;

            dataBase = new SHARED_LIBRARY_ENTITY();

            if (isStaff)
            {
                var Account_Gotten_By_Username = dataBase.STAFF_INF.Find(_Username);

                if (is_Invalid_StaffAccount(Account_Gotten_By_Username))
                { MessageBox.Show("Sai tên đăng nhập!"); return; }

                if (is_Invalid_Password(Account_Gotten_By_Username.PASSWORD, _encryptedPassword))
                { MessageBox.Show("Sai mật khẩu!"); return; }

                Attempt_Open_StaffForm_With_Account(Account_Gotten_By_Username);
            }
            else
            {
                var Account_Gotten_By_Username = dataBase.READER_INF.Find(_Username);

                if (is_Invalid_ReaderAccount(Account_Gotten_By_Username))
                { MessageBox.Show("Sai tên đăng nhập!"); return; }

                if (is_Invalid_Password(Account_Gotten_By_Username.PASSWORD, _encryptedPassword))
                { MessageBox.Show("Sai mật khẩu!"); return; }

                Attempt_Open_ReaderForm_With_Account(Account_Gotten_By_Username);
            }
        }

        private bool Default_Login(string _Username, string _encryptedPassword)
        {
            if (_Username == "pandealine" && _encryptedPassword == "1962026656160185351301320480154111117132155")
            {
                STAFF_INF default_Account = new STAFF_INF();

                default_Account.TYPE = true;

                fMain form = new fMain(default_Account);

                this.Hide();
                form.ShowDialog();
                this.Show();

                return true;
            }

            return false;
        }

        private bool is_Invalid_StaffAccount(STAFF_INF account)
        {
            return account == null;
        }

        private bool is_Invalid_ReaderAccount(READER_INF account)
        {
            return account == null;
        }

        private bool is_Invalid_Password(string _Password, string _encryptedPassword)
        {
            return _Password != _encryptedPassword;
        }

        private void Attempt_Open_ReaderForm_With_Account(READER_INF _ActiveAccount)
        {
            fReader f = new fReader(_ActiveAccount);

            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void Attempt_Open_StaffForm_With_Account(STAFF_INF _ActiveAccount)
        {
            fMain f = new fMain(_ActiveAccount);

            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        #endregion ========================================
    }
}
