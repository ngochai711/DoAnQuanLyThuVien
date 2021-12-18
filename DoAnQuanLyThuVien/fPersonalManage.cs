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
        //
        //
        //---Region_1---
        #region ===============Controls_Events===============
        private void simpleButton_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton_Reload_Click(object sender, EventArgs e)
        {
            data_Load();
        }

        private void simpleButton_readerEdit_Click(object sender, EventArgs e)
        {
            rEADERINFBindingSource.EndEdit();

            dataChange_Save();
        }

        private void simpleButton_staffEdit_Click(object sender, EventArgs e)
        {
            sTAFFINFBindingSource.EndEdit();

            dataChange_Save();
        }
        #endregion
        //--------------
        //
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
        #endregion
        //--------------
        //
        //
        private void simpleButton_readerAdd_Click(object sender, EventArgs e)
        {
            fnewAccount f = new fnewAccount();
            f.ShowDialog();
            data_Load();
        }

        private void simpleButton_readerDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa thông tin này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var item = rEADERINFBindingSource.Current as READER_INF;

                dataBase.Entry<READER_INF>(item).State = System.Data.Entity.EntityState.Deleted;
                dataBase.SaveChanges();

                rEADERINFBindingSource.RemoveCurrent();
            }
        }

        private void button_resetPass_Click(object sender, EventArgs e)
        {
            var item = rEADERINFBindingSource.Current as READER_INF;

            item.PASSWORD = "1";

            dataBase.READER_INF.AddOrUpdate(item);
            dataBase.SaveChanges();

            data_Load();
        }

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

        private void simpleButton5_Click(object sender, EventArgs e)
        {

        }
    }
}
