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
                if (isStaff)
                    delete_staffAccount();
                else
                    delete_readerAccount();          
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

        private void simpleButton_resetPass_Click(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.SimpleButton eventCalled_Button = sender as DevExpress.XtraEditors.SimpleButton;

            if (eventCalled_Button.Name == "simpleButton_staff_resetPass")
                resetPass_Staff();
            else
                resetPass_Reader();

            data_Load();
        }
        #endregion

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

        private void delete_readerAccount()
        {
            var item = rEADERINFBindingSource.Current as READER_INF;

            dataBase.Entry<READER_INF>(item).State = System.Data.Entity.EntityState.Deleted;
            dataBase.SaveChanges();

            rEADERINFBindingSource.RemoveCurrent();
        }

        private void delete_staffAccount()
        {
            var item = sTAFFINFBindingSource.Current as STAFF_INF;

            dataBase.Entry<STAFF_INF>(item).State = System.Data.Entity.EntityState.Deleted;
            dataBase.SaveChanges();

            sTAFFINFBindingSource.RemoveCurrent();
        }

        private void resetPass_Reader()
        {
            var item = rEADERINFBindingSource.Current as READER_INF;

            item.PASSWORD = "1";

            dataBase.READER_INF.AddOrUpdate(item);
            dataBase.SaveChanges();
        }

        private void resetPass_Staff()
        {
            var item = sTAFFINFBindingSource.Current as STAFF_INF;

            item.PASSWORD = "1";

            dataBase.STAFF_INF.AddOrUpdate(item);
            dataBase.SaveChanges();
        }
        #endregion

        private void AVATARPictureEdit_Click(object sender, EventArgs e)
        {
            openFileDialog_Avatar.CheckFileExists = true;
            openFileDialog_Avatar.CheckPathExists = true;
            openFileDialog_Avatar.Multiselect = false;
            openFileDialog_Avatar.Title = "Chosen As - Avatar";
            openFileDialog_Avatar.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All Files(*.*)|*.*";
            
            if (openFileDialog_Avatar.ShowDialog() == DialogResult.OK)
            {
                byte[] img = null;
                FileStream fs = new FileStream(openFileDialog_Avatar.FileName, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);

                var item = rEADERINFBindingSource.Current as READER_INF;

                item.AVATAR = img;

                dataBase.READER_INF.AddOrUpdate(item);
                dataBase.SaveChanges();

                data_Load();
            }
        }

        private void button_Account_Click(object sender, EventArgs e)
        {
            READER_INF focused = (READER_INF)gridView_Reader.GetFocusedRow();
            fAccount f = new fAccount(focused.USERNAME, focused.PASSWORD);
            
            f.ShowDialog();
            
            data_Load();
        }
    }
}
