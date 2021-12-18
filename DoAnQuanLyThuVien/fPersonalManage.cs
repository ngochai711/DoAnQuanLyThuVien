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

namespace DoAnQuanLyThuVien
{
    public partial class fPersonalManage : Form
    {
        private SHARED_LIBRARY_ENTITY dataBase;

        public fPersonalManage()
        {
            InitializeComponent();

            data_Load();

            //dataLayoutControl_Reader.OptionsView.IsReadOnly = DevExpress.Utils.DefaultBoolean.True;
        }
 


        //---Region_1---
        #region ===============Controls_Events===============

        private void simpleButton_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton_Add_Click(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.SimpleButton eventCalled_Button = sender as DevExpress.XtraEditors.SimpleButton;
            
            bool isStaff = eventCalled_Button.Name == "simpleButton_staffAdd";
            
            fnewAccount f = new fnewAccount(isStaff);
            f.ShowDialog();

            data_Load();
        }

        private void simpleButton_Del_Click(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.SimpleButton eventCalled_Button = sender as DevExpress.XtraEditors.SimpleButton;
            
            bool isStaff = eventCalled_Button.Name == "simpleButton_staffDel";

            if (MessageBox.Show("Xóa tài khoản này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    delete_Account(isStaff);          
        }

        private void simpleButton_Edit_Click(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.SimpleButton eventCalled_Button = sender as DevExpress.XtraEditors.SimpleButton;

            if (eventCalled_Button.Name == "simpleButton_staffEdit")
                sTAFFINFBindingSource.EndEdit();
            else
                rEADERINFBindingSource.EndEdit();

            dataChange_Save();
        }

        private void simpleButton_Reload_Click(object sender, EventArgs e)
        {
            data_Load();
        }

        private void simpleButton_Account_Click(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.SimpleButton eventCalled_Button = sender as DevExpress.XtraEditors.SimpleButton;

            bool isStaff = eventCalled_Button.Name == "simpleButton_staffAccount";

            fAccount accountForm = null;

            if (isStaff)
            {
                var current_staffAccount = sTAFFINFBindingSource.Current as STAFF_INF;

                accountForm = new fAccount(current_staffAccount.USERNAME, current_staffAccount.PASSWORD, isStaff);
            }
            else
            {
                var current_readerAccount = rEADERINFBindingSource.Current as READER_INF;

                accountForm = new fAccount(current_readerAccount.USERNAME, current_readerAccount.PASSWORD, isStaff);
            }

            accountForm.ShowDialog();

            data_Load();
        }

        private void simpleButton_resetPass_Click(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.SimpleButton eventCalled_Button = sender as DevExpress.XtraEditors.SimpleButton;

            bool isStaff = eventCalled_Button.Name == "simpleButton_staff_resetPass";

            reset_Pass(isStaff);

            data_Load();
        }

        private void pictureEdit_AVATARPictureEdit_Click(object sender, EventArgs e)
        {
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

                update_accountAvatar(isStaff, _AVATAR);
            }
        }

        #endregion ==========================================



        //---Region_2---
        #region ================Funcs_&_Procs================

        private void data_Load()
        {
            dataBase = new SHARED_LIBRARY_ENTITY();

            rEADERINFBindingSource.DataSource = dataBase.READER_INF.ToList();
            sTAFFINFBindingSource.DataSource = dataBase.STAFF_INF.ToList();
        }

        private void dataChange_Save()
        {
            if (dataBase.SaveChanges() == 1)
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

        private void reset_Pass(bool _isStaff)
        {
            string defaultPassword = "1";

            if (_isStaff)
            {
                var item = sTAFFINFBindingSource.Current as STAFF_INF;

                item.PASSWORD = defaultPassword;

                dataBase.STAFF_INF.AddOrUpdate(item);
            }
            else
            {
                var item = rEADERINFBindingSource.Current as READER_INF;

                item.PASSWORD = defaultPassword;

                dataBase.READER_INF.AddOrUpdate(item);
            }    

            dataBase.SaveChanges();
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

            dataBase.SaveChanges();

            data_Load();
        }

        #endregion==========================================
    }
}
