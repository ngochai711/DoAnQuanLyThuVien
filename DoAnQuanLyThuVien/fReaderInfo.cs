using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQuanLyThuVien.DTO;
using System.Data.Entity.Migrations;
using System.IO;
using System.Security.Cryptography;
using System.Resources;
using System.Reflection;
using DevExpress.Utils.Svg;

namespace DoAnQuanLyThuVien
{
    public partial class fReaderInfo : DevExpress.XtraEditors.XtraForm
    {
        private READER_INF activeAccount = null;
        private bool isEditting = false;

        public fReaderInfo(READER_INF account)
        {
            activeAccount = account;

            InitializeComponent();

            Set_DateFormat();
        }

        //---Region_Controls_Events---
        #region ===============Controls_Events===============

        private void xtrafReaderInfo_Load(object sender, EventArgs e)
        {
            Get_ActiveAccount_Data();

            Enable_Disable_ReadOnly();
        }

        private void simpleButton_EDIT_Click(object sender, EventArgs e)
        {
            isEditting = !isEditting;

            Enable_Disable_ReadOnly();

            if (isEditting)
            {
                Set_EditButton_Icon(Properties.Resources.saveto_32x32);
            }
            else
            {
                Set_EditButton_Icon(Properties.Resources.editcontact_32x32);

                Update_ActiveAccount();
            }
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

        private void simpleButton_changePassword_Click(object sender, EventArgs e)
        {
            if (isEditting)
            { MessageBox.Show("Có thay đổi chưa được lưu!"); return; }

            Show_PasswordChange_GUI();
        }

        private void ALLPASSWORDtextEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (All_PasswordTextBox_isFilled())
                simpleButton_SAVE.Text = "Lưu";
            else
                simpleButton_SAVE.Text = "Hủy";
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

        #endregion ==========================================

        //---Region_Funcs_&_Procs---
        #region ================Funcs_&_Procs================

        private void Set_DateFormat()
        {
            this.BIRTHdateEdit.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.BIRTHdateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.BIRTHdateEdit.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.BIRTHdateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.BIRTHdateEdit.Properties.Mask.EditMask = "dd/MM/yyyy";
        }

        private void Set_EditButton_Icon(Bitmap Icon)
        {
            simpleButton_EDIT.ImageOptions.Image = Icon;
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

        private void Get_ActiveAccount_NewValue()
        {
            activeAccount.AVATAR = (byte[])AVATARpictureEdit.EditValue;
            activeAccount.NAME = NAMEtextEdit.Text;
            activeAccount.PID = PIDtextEdit.Text;
            activeAccount.BIRTH = (DateTime)BIRTHdateEdit.EditValue;
            activeAccount.AGE = Convert.ToByte(AGEtextEdit.Text);
            activeAccount.SEX = SEXcomboboxEdit.EditValue.ToString();
            activeAccount.ADDRESS = ADDRESStextEdit.Text;
            activeAccount.PHONE = PHONEtextEdit.Text;
            activeAccount.EMAIL = EMAILtextEdit.Text;
            activeAccount.NOTE = NOTEmemoEdit.Text;
        }

        private void Enable_Disable_ReadOnly()
        {
            AVATARpictureEdit.ReadOnly = !isEditting;
            NAMEtextEdit.ReadOnly = !isEditting;
            PIDtextEdit.ReadOnly = !isEditting;
            BIRTHdateEdit.ReadOnly = !isEditting;
            SEXcomboboxEdit.ReadOnly = !isEditting;
            ADDRESStextEdit.ReadOnly = !isEditting;
            PHONEtextEdit.ReadOnly = !isEditting;
            EMAILtextEdit.ReadOnly = !isEditting;
            NOTEmemoEdit.ReadOnly = !isEditting;
        }

        private byte[] get_binaryImage_from_Path(string _fileName)
        {
            FileStream fileStream = new FileStream(_fileName, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            byte[] binaryImage = binaryReader.ReadBytes((int)fileStream.Length);

            return binaryImage;
        }

        private void Update_ActiveAccount()
        {
            SHARED_LIBRARY_ENTITY dataBase = new SHARED_LIBRARY_ENTITY();

            Get_ActiveAccount_NewValue();

            dataBase.READER_INF.AddOrUpdate(activeAccount);

            try
            {
                if (dataBase.SaveChanges() == 1)
                { MessageBox.Show("Cập nhật tài khoản thành công!"); }
            }
            catch
            {
                MessageBox.Show("Cập nhật tài khoản thất bại! Vui lòng kiểm tra lại thông tin vừa nhập!");
            }

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

        private bool All_PasswordTextBox_isFilled()
        {
            return PASSWORDtextEdit.Text != "" &&
                   NEWPASStextEdit.Text != "" &&
                   CONFIRMPASStextEdit.Text != "";
        }

        private bool Unmatched_OldPassword()
        {
            string Encrypted_OldPassword = Encrypt_Password(PASSWORDtextEdit.Text);

            return Encrypted_OldPassword != activeAccount.PASSWORD;
        }

        private bool Unmatched_NewPassword()
        {
            return NEWPASStextEdit.Text != CONFIRMPASStextEdit.Text;
        }

        private void Update_ActiveAccount_NewPassword()
        {
            string Encrypted_NewPassword = Encrypt_Password(NEWPASStextEdit.Text);

            activeAccount.PASSWORD = Encrypted_NewPassword;

            Update_ActiveAccount();
        }

        #endregion ==========================================
    }
}