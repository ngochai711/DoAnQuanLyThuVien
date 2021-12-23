using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQuanLyThuVien.DTO;
using DoAnQuanLyThuVien.DAO;
using System.Data.Entity.Migrations;
using DevExpress.XtraEditors;
using System.Data.Entity;

namespace DoAnQuanLyThuVien
{
    public partial class fPersonalManage : Form
    {
        private bool is_edittingMode = false;
        private STAFF_INF currentAccount = null;
        private SHARED_LIBRARY_ENTITY dataBase = new SHARED_LIBRARY_ENTITY();

        public fPersonalManage(STAFF_INF _currentAccount)
        {
            InitializeComponent();

            data_Load();

            currentAccount = _currentAccount;

            Set_DateFormat();
        }



        //---Region_Controls_Events---
        #region ===============Controls_Events===============

        private void simpleButton_Close_Click(object sender, EventArgs e)
        {
            if (is_edittingMode)
            { MessageBox.Show("Các thay đổi chưa được lưu!"); return; }

            this.Close();
        }

        private void simpleButton_Add_Click(object sender, EventArgs e)
        {
            if (is_edittingMode)
            { MessageBox.Show("Các thay đổi chưa được lưu!"); return; }

            SimpleButton eventCalled_Button = sender as SimpleButton;
            
            bool isStaff = eventCalled_Button.Name == "simpleButton_staffAdd";

            if (isStaff && currentAccount.TYPE == false)
            { MessageBox.Show("Bản phải là quản lý để có thể thực hiện chức năng này"); return; }

            fnewAccount f = new fnewAccount(isStaff);
            f.ShowDialog();

            data_Load();
        }

        private void simpleButton_Del_Click(object sender, EventArgs e)
        {
            if (is_edittingMode)
            { MessageBox.Show("Các thay đổi chưa được lưu!"); return; }

            DevExpress.XtraEditors.SimpleButton eventCalled_Button = sender as DevExpress.XtraEditors.SimpleButton;
            
            bool isStaff = eventCalled_Button.Name == "simpleButton_staffDel";

            if (isStaff && currentAccount.TYPE == false)
            { MessageBox.Show("Bản phải là quản lý để có thể thực hiện chức năng này"); return; }

            if (MessageBox.Show("Xóa tài khoản này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    delete_Account(isStaff);          
        }

        private void simpleButton_Edit_Click(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.SimpleButton eventCalled_Button = sender as DevExpress.XtraEditors.SimpleButton;

            if (currentAccount.TYPE == false)
            focus_currentAccount();

            if (is_edittingMode)
            {
                try
                {
                    save_editedInfo(eventCalled_Button.Name);
                }
                catch
                {
                    MessageBox.Show("Dữ liệu không hợp lệ!");
                    
                    Reload_DataView();
                    
                    return;
                }

                eventCalled_Button.Text = "Cập nhật";
            }
            else
                eventCalled_Button.Text = "Lưu";

            is_edittingMode = !is_edittingMode;

            enable_disable_Editing(eventCalled_Button.Name);
        }

        private void simpleButton_Reload_Click(object sender, EventArgs e)
        {
            Reload_DataView();    
        }

        private void simpleButton_Account_Click(object sender, EventArgs e)
        {
            if (is_edittingMode)
            { MessageBox.Show("Các thay đổi chưa được lưu!"); return; }

            DevExpress.XtraEditors.SimpleButton eventCalled_Button = sender as DevExpress.XtraEditors.SimpleButton;

            bool isStaff = eventCalled_Button.Name == "simpleButton_staffAccount";

            Form accountForm = null;

            if (isStaff)
            {
                accountForm = new fStaffAccount(currentAccount);
            }
            else
            {
                var current_readerAccount = rEADERINFBindingSource.Current as READER_INF;

                accountForm = new fReaderAccount(current_readerAccount.USERNAME);
            }

            accountForm.ShowDialog();

            data_Load();
        }

        private void simpleButton_resetPass_Click(object sender, EventArgs e)
        {
            if (is_edittingMode)
            { MessageBox.Show("Các thay đổi chưa được lưu!"); return; }

            DevExpress.XtraEditors.SimpleButton eventCalled_Button = sender as DevExpress.XtraEditors.SimpleButton;

            bool isStaff = eventCalled_Button.Name == "simpleButton_staff_resetPass";

            reset_Pass(isStaff);

            data_Load();
        }

        private void pictureEdit_AVATARPictureEdit_Click(object sender, EventArgs e)
        {
            if (!is_edittingMode) { return; }

            DevExpress.XtraEditors.PictureEdit accountAvatar = sender as DevExpress.XtraEditors.PictureEdit;
            
            bool isStaff = accountAvatar.Name == "STAFFAVATARpictureEdit";

            OpenFileDialog browseImage_Dialog = new OpenFileDialog();

            browseImage_Dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All Files(*.*)|*.*";
            browseImage_Dialog.Title = "Chosen As - Avatar";
            browseImage_Dialog.CheckFileExists = true;
            browseImage_Dialog.CheckPathExists = true;
            browseImage_Dialog.Multiselect = false;

            if (browseImage_Dialog.ShowDialog() == DialogResult.OK)
            {
                byte[] _AVATAR = get_binaryImage_from_Path(browseImage_Dialog.FileName);

                if (isStaff)
                    STAFFAVATARpictureEdit.EditValue = _AVATAR;
                else
                    READERAVATARPictureEdit.EditValue = _AVATAR;

                update_accountAvatar(isStaff, _AVATAR);
            }
        }

        private void gridView_Staff_BeforeLeaveRow(object sender, DevExpress.XtraGrid.Views.Base.RowAllowEventArgs e)
        {
            if (is_edittingMode && currentAccount.TYPE == false)
                e.Allow = false;
        }

        #endregion ==========================================



        //---Region_Funcs_&_Procs---
        #region ================Funcs_&_Procs================

        private void Set_DateFormat()
        {
            this.STAFFBIRTHdateEdit.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.STAFFBIRTHdateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.STAFFBIRTHdateEdit.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.STAFFBIRTHdateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.STAFFBIRTHdateEdit.Properties.Mask.EditMask = "dd/MM/yyyy";

            this.READERBIRTHDateEdit.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.READERBIRTHDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.READERBIRTHDateEdit.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.READERBIRTHDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.READERBIRTHDateEdit.Properties.Mask.EditMask = "dd/MM/yyyy";
        }

        private void data_Load()
        {
            dataBase.READER_INF.Load();
            dataBase.STAFF_INF.Load();

            rEADERINFBindingSource.DataSource = dataBase.READER_INF.ToList();
            sTAFFINFBindingSource.DataSource = dataBase.STAFF_INF.ToList();
        }

        private void dataChange_Save()
        {
            if (dataBase.SaveChanges() >= 1)
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK);

                data_Load();
            }
        }

        private void delete_Account(bool _isStaff)
        {
            if (_isStaff)
            {
                var item = sTAFFINFBindingSource.Current as STAFF_INF;

                sTAFFINFBindingSource.RemoveCurrent();

                dataBase.Entry<STAFF_INF>(item).State = System.Data.Entity.EntityState.Deleted;
            }
            else
            {
                var item = rEADERINFBindingSource.Current as READER_INF;

                rEADERINFBindingSource.RemoveCurrent();

                dataBase.Entry<READER_INF>(item).State = System.Data.Entity.EntityState.Deleted;
            }

            dataBase.SaveChanges();
        }

        private void focus_currentAccount()
        {
            var obj = sTAFFINFBindingSource.List.OfType<STAFF_INF>().ToList().Find(f => f.USERNAME == currentAccount.USERNAME);

            int currentAccount_Index = sTAFFINFBindingSource.IndexOf(obj);

            int currentAccount_rowHandle = gridView_Staff.GetRowHandle(currentAccount_Index);

            gridView_Staff.FocusedRowHandle = currentAccount_rowHandle;
        }

        private void enable_disable_Editing(string eventCalled_buttonName)
        {
            if (eventCalled_buttonName == "simpleButton_staffEdit")
            {
                STAFFNAMEtextEdit.ReadOnly = !is_edittingMode;
                STAFFNAMEtextEdit.BorderStyle = is_edittingMode ? 
                                                DevExpress.XtraEditors.Controls.BorderStyles.Flat : 
                                                DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                TYPECheckEdit.ReadOnly = !is_edittingMode || !(bool)currentAccount.TYPE;
                STAFFPIDTextEdit.ReadOnly = !is_edittingMode;
                STAFFBIRTHdateEdit.ReadOnly = !is_edittingMode;
                STAFFSEXcomboBoxEdit.ReadOnly = !is_edittingMode;
                STAFFADDRESStextEdit.ReadOnly = !is_edittingMode;
                STAFFPHONEtextEdit.ReadOnly = !is_edittingMode;
                STAFFEMAILtextEdit.ReadOnly = !is_edittingMode;
                STAFFNOTEmemoEdit.ReadOnly = !is_edittingMode;
                STAFFPIDTextEdit.Focus();
            }
            else
            {
                READERNAMETextEdit.ReadOnly = !is_edittingMode;
                READERNAMETextEdit.BorderStyle = is_edittingMode ? 
                                                DevExpress.XtraEditors.Controls.BorderStyles.Flat : 
                                                DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                READERPIDTextEdit.ReadOnly = !is_edittingMode;
                READERBIRTHDateEdit.ReadOnly = !is_edittingMode;
                READERSEXComboBoxEdit.ReadOnly = !is_edittingMode;
                READERADDRESSTextEdit.ReadOnly = !is_edittingMode;
                READERPHONETextEdit.ReadOnly = !is_edittingMode;
                READEREMAILTextEdit.ReadOnly = !is_edittingMode;
                READERNOTEMemoEdit.ReadOnly = !is_edittingMode;
                READERPIDTextEdit.Focus();
            }
        }

        private void save_editedInfo(string eventCalled_buttonName)
        {
            if (eventCalled_buttonName == "simpleButton_staffEdit")
            {
                sTAFFINFBindingSource.EndEdit();

                STAFFAVATARpictureEdit.Focus();
            }    
            else
            {
                rEADERINFBindingSource.EndEdit();

                READERAVATARPictureEdit.Focus();
            }

            dataChange_Save();
        }

        private void Reload_DataView()
        {
            var Modified_Accounts = dataBase.ChangeTracker.Entries().Where(t => t.State == EntityState.Modified).ToList();

            foreach (var Account in Modified_Accounts)
            {
                Account.CurrentValues.SetValues(Account.OriginalValues);
                Account.State = EntityState.Unchanged;
            }

            data_Load();
        }

        private void reset_Pass(bool _isStaff)
        {
            string defaultPassword = "1962026656160185351301320480154111117132155";

            if (_isStaff)
            {
                STAFF_INF item;

                if (currentAccount.TYPE == false)
                {
                    item = currentAccount;

                    focus_currentAccount();
                }
                else
                    item = sTAFFINFBindingSource.Current as STAFF_INF;

                item.PASSWORD = defaultPassword;

                dataBase.STAFF_INF.AddOrUpdate(item);
            }
            else
            {
                var item = rEADERINFBindingSource.Current as READER_INF;

                item.PASSWORD = defaultPassword;

                dataBase.READER_INF.AddOrUpdate(item);
            }    

            if (dataBase.SaveChanges() == 1)
                MessageBox.Show("Đặt lại mật khẩu thành công!");
        }

        private byte[] get_binaryImage_from_Path(string _fileName)
        {
            FileStream fileStream = new FileStream(_fileName, FileMode.Open, FileAccess.Read);

            BinaryReader binaryReader = new BinaryReader(fileStream);

            byte[] binaryImage = binaryReader.ReadBytes((int)fileStream.Length);

            return binaryImage;
        }

        private void update_accountAvatar(bool _isStaff, byte[] __AVATAR)
        {
            if (_isStaff)
            {
                var item = sTAFFINFBindingSource.Current as STAFF_INF;

                item.AVATAR = __AVATAR;

                dataBase.STAFF_INF.AddOrUpdate(item);
            }
            else
            {
                var item = rEADERINFBindingSource.Current as READER_INF;

                item.AVATAR = __AVATAR;

                dataBase.READER_INF.AddOrUpdate(item);
            }
        }

        #endregion==========================================
    }
}
