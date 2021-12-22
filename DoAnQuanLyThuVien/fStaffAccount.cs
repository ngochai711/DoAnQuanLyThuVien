using DoAnQuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Migrations;
using DoAnQuanLyThuVien.DTO;
using System.Security.Cryptography;

namespace DoAnQuanLyThuVien
{
    public partial class fStaffAccount : Form
    {
        private SHARED_LIBRARY_ENTITY dataBase = new SHARED_LIBRARY_ENTITY();

        private STAFF_INF currentAccount;

        private bool is_passChanging_Mode = false;

        public fStaffAccount(STAFF_INF _currentAccount)
        {
            currentAccount = _currentAccount;

            InitializeComponent();
        }



        //---Region_1---
        #region ===============Controls_Events===============

        private void fAccount_Load(object sender, EventArgs e)
        {
            setting_formLayout();
        }

        private void hyperlinkLabelControl_changePass_Click(object sender, EventArgs e)
        {
            is_passChanging_Mode = !is_passChanging_Mode;

            setting_formLayout();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {

            if (unmatched_oldPassword())
            { MessageBox.Show("Sai mật khẩu cũ!"); return; }

            if (unmatched_newPassword())
            { MessageBox.Show("Mật khẩu mới không trùng khớp!"); return; }

            try
            {
                Update_newPassword();

                is_passChanging_Mode = !is_passChanging_Mode;

                setting_formLayout();
            }
            catch
            {
                MessageBox.Show("Mật khẩu mới không hợp lệ!");
            }
        }

        #endregion ==========================================


        //---Region_2---
        #region ================Funcs_&_Procs================

        private void setting_formLayout()
        {
            //---------------
            SizeF formScale = new System.Drawing.SizeF(8F, 16F);
            Size clientSize_normalState = new System.Drawing.Size(490, 193);
            Size clientSize_passChange_State = new System.Drawing.Size(490, 359);

            //---------------
            if (is_passChanging_Mode)
                Resize_Form(formScale, clientSize_passChange_State);
            else
                Resize_Form(formScale, clientSize_normalState);

            //---------------
            Setting_passChanging_Controls_Visibility();


            //---------------
            Setting_accountInfo_displayControls();


            //---------------
            hyperlinkLabelControl_changePass.Text = !is_passChanging_Mode ? "Mật khẩu mới" : "Hủy";
        }

        private void Setting_accountInfo_displayControls()
        {
            ItemForUSERNAME.Text = "Tên đăng nhập";
            USERNAMETextEdit.Text = currentAccount.USERNAME;
            USERNAMETextEdit.ReadOnly = true;

            ItemForPASSWORD.Text = !is_passChanging_Mode ? "Mật khẩu" : "Mật khẩu cũ";
            PASSWORDTextEdit.Text = !is_passChanging_Mode ? "123456789" : "";
            PASSWORDTextEdit.ReadOnly = !is_passChanging_Mode;
            PASSWORDTextEdit.Focus();
        }

        private void Setting_passChanging_Controls_Visibility()
        {
            layoutControlItem_newPass.ContentVisible = is_passChanging_Mode;
            layoutControlItem_reEnter.ContentVisible = is_passChanging_Mode;
            button_Save.Visible = is_passChanging_Mode;

            NEWPASStextEdit.Text = "";
            REENTERtextEdit.Text = "";
        }

        private void Resize_Form(SizeF _formScale, Size _formSize)
        {
            SuspendLayout();
            this.AutoScaleDimensions = _formScale;
            this.ClientSize = _formSize;
            ResumeLayout(false);
        }

        private string Encrypt_Password(string _needEncrypt_Password)
        {
            byte[] password_byteArray = ASCIIEncoding.ASCII.GetBytes(_needEncrypt_Password);

            byte[] byte_hashedPassword = new MD5CryptoServiceProvider().ComputeHash(password_byteArray);

            string str_hashedPassword = "";

            foreach (byte item in byte_hashedPassword)
            {
                str_hashedPassword += item;
            }

            return str_hashedPassword;
        }

        private void Update_newPassword()
        {
            string encryptedPassword = Encrypt_Password(NEWPASStextEdit.Text);

            currentAccount.PASSWORD = encryptedPassword;
            dataBase.STAFF_INF.AddOrUpdate(currentAccount);

            if (dataBase.SaveChanges() == 1)
                MessageBox.Show("Đổi mật khẩu thành công!"); ;
        }

        private bool unmatched_newPassword()
        {
            return NEWPASStextEdit.Text != REENTERtextEdit.Text;
        }

        private bool unmatched_oldPassword()
        {
            string encryptedPassword = Encrypt_Password(PASSWORDTextEdit.Text);

            return encryptedPassword != currentAccount.PASSWORD;
        }

        #endregion ==========================================
    }
}
