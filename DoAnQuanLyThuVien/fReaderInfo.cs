using DevExpress.XtraEditors;
using DoAnQuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLyThuVien
{
    public partial class fReaderInfo : Form
    {
        private READER_INF activeAccount = null;
        private bool isEditting = false;

        public fReaderInfo(READER_INF account)
        {
            activeAccount = account;

            InitializeComponent();
        }

        private void Enable_Disable_ReadOnly()
        {
            AVATARpictureEdit.ReadOnly = !isEditting;
            NAMEtextEdit.ReadOnly = !isEditting;
            PIDtextEdit.ReadOnly = !isEditting;
            BIRTHdateEdit.ReadOnly = !isEditting;
            AGEtextEdit.ReadOnly = !isEditting;
            SEXcomboboxEdit.ReadOnly = !isEditting;
            ADDRESStextEdit.ReadOnly = !isEditting;
            PHONEtextEdit.ReadOnly = !isEditting;
            EMAILtextEdit.ReadOnly = !isEditting;
            NOTEmemoEdit.ReadOnly = !isEditting;
        }

        private void Get_ActiveAccount_Data()
        {
            AVATARpictureEdit.EditValue = activeAccount.AVATAR;
            USERNAMEtextEdit.Text = activeAccount.USERNAME;
            READERIDtextEdit.Text = activeAccount.READERID;
            NAMEtextEdit.Text = activeAccount.NAME;
            PIDtextEdit.Text = activeAccount.PID;
            BIRTHdateEdit.EditValue = activeAccount.BIRTH;
            AGEtextEdit.Text = activeAccount.AGE.ToString();
            SEXcomboboxEdit.EditValue = activeAccount.SEX;
            ADDRESStextEdit.Text = activeAccount.ADDRESS;
            PHONEtextEdit.Text = activeAccount.PHONE;
            EMAILtextEdit.Text = activeAccount.EMAIL;
            NOTEmemoEdit.Text = activeAccount.NOTE;
        }

        private void fReaderInfo_Load(object sender, EventArgs e)
        {
            Get_ActiveAccount_Data();

            Enable_Disable_ReadOnly();
        }

        private void simpleButton_EDIT_Click(object sender, EventArgs e)
        {
            isEditting = !isEditting;

            Enable_Disable_ReadOnly();

            if (isEditting)
                Update_ActiveAccount();
        }

        void Update_ActiveAccount()
        {
            SHARED_LIBRARY_ENTITY dataBase = new SHARED_LIBRARY_ENTITY();

            dataBase.READER_INF.AddOrUpdate(activeAccount);

            if (dataBase.SaveChanges() == 1)
            { MessageBox.Show("Cập nhật tài khoản thành công!"); }    
        }

        private void AVATARpictureEdit_Click(object sender, EventArgs e)
        {
            if (!isEditting) return;

            OpenFileDialog browseImage_Dialog = new OpenFileDialog();

            browseImage_Dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All Files(*.*)|*.*";
            browseImage_Dialog.Title = "Chosen As - Avatar";
            browseImage_Dialog.CheckFileExists = true;
            browseImage_Dialog.CheckPathExists = true;
            browseImage_Dialog.Multiselect = false;

            if (browseImage_Dialog.ShowDialog() == DialogResult.OK)
            {
                byte[] _AVATAR = get_binaryImage_from_Path(browseImage_Dialog.FileName);

                activeAccount.AVATAR = _AVATAR;

                AVATARpictureEdit.EditValue = _AVATAR;
            }
        }


        private byte[] get_binaryImage_from_Path(string _fileName)
        {
            FileStream fileStream = new FileStream(_fileName, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            byte[] binaryImage = binaryReader.ReadBytes((int)fileStream.Length);

            return binaryImage;
        }

        private void simpleButton_changePassword_Click(object sender, EventArgs e)
        {
            if (isEditting)
            { MessageBox.Show("Có thay đổi chưa được lưu!"); return; }

            Show_PasswordChange_GUI();
        }

        private void Show_PasswordChange_GUI()
        {
            PASSWORDtextEdit.Text = "";

            simpleButton_SAVE.Visible = true;
            PASSWORDtextEdit.ReadOnly = false;
            simpleButton_changePassword.Visible = false;

            layoutControlGroup_NEWPASS.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;

            PASSWORDtextEdit.Focus();
        }

        private void simpleButton_SAVE_Click(object sender, EventArgs e)
        {
            if ((sender as SimpleButton).Text == "Lưu")
            {
                if (Unmatched_OldPassword())
                { MessageBox.Show("Mật khẩu cũ không trùng khớp!"); return; }

                if (Unmatched_NewPassword())
                { MessageBox.Show("Mật khẩu mới không trùng khớp!"); return; }

                Update_ActiveAccount_NewPassword();
            }

            Hide_PasswordChange_GUI();

        }

        private void Hide_PasswordChange_GUI()
        {
            NEWPASStextEdit.Text = "";
            CONFIRMPASStextEdit.Text = "";
            PASSWORDtextEdit.Text = "123456789";

            PASSWORDtextEdit.ReadOnly = true;
            simpleButton_SAVE.Visible = false;
            simpleButton_changePassword.Visible = true;

            layoutControlGroup_NEWPASS.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        private void Update_ActiveAccount_NewPassword()
        {
            string Encrypted_NewPassword = Encrypt_Password(NEWPASStextEdit.Text);

            activeAccount.PASSWORD = Encrypted_NewPassword;

            Update_ActiveAccount();
        }

        private bool Unmatched_NewPassword()
        {
            return NEWPASStextEdit.Text != CONFIRMPASStextEdit.Text;
        }

        private string Encrypt_Password(string NeedEncrypt_Password)
        {
            byte[] password_byteArray = ASCIIEncoding.ASCII.GetBytes(NeedEncrypt_Password);

            byte[] byte_hashedPassword = new MD5CryptoServiceProvider().ComputeHash(password_byteArray);

            string str_hashedPassword = "";

            foreach (byte item in byte_hashedPassword)
            {
                str_hashedPassword += item;
            }

            return str_hashedPassword;
        }

        private bool Unmatched_OldPassword()
        {
            string Encrypted_OldPassword = Encrypt_Password(PASSWORDtextEdit.Text);

            return Encrypted_OldPassword != activeAccount.PASSWORD;
        }

        private void ALLPASSWORDtextEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (All_PasswordTextBox_isFilled())
                simpleButton_SAVE.Text = "Lưu";
            else
                simpleButton_SAVE.Text = "Hủy";
        }

        private bool All_PasswordTextBox_isFilled()
        {
            return PASSWORDtextEdit.Text != "" &&
                   NEWPASStextEdit.Text != "" &&
                   CONFIRMPASStextEdit.Text != "";
        }
    }
}
