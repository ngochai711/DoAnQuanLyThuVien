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
        private SHARED_LIBRARY_ENTITY dtb = new SHARED_LIBRARY_ENTITY();

        public fPersonalManage()
        {
            InitializeComponent();

            Load_Data();
        }

        private void Load_Data()
        {
            rEADERINFBindingSource.DataSource = dtb.READER_INF.ToList();
            sTAFFINFBindingSource.DataSource = dtb.STAFF_INF.ToList();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            fnewAccount f = new fnewAccount();
            f.ShowDialog();
            Load_Data();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa thông tin này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                READER_INF item = rEADERINFBindingSource.Current as READER_INF;

                dtb.Entry<READER_INF>(item).State = System.Data.Entity.EntityState.Deleted;
                dtb.SaveChanges();
                
                rEADERINFBindingSource.RemoveCurrent();
            }
        }

        private void Button_Edit_Click(object sender, EventArgs e)
        {
            rEADERINFBindingSource.EndEdit();

            if (dtb.SaveChanges() == 1)
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK);

                Load_Data();
            }
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            rEADERINFBindingSource.ResetBindings(false);
         
            Load_Data();
        }

        private void button_resetPass_Click(object sender, EventArgs e)
        {
            var item = rEADERINFBindingSource.Current as READER_INF;

            item.PASSWORD = "1";

            dtb.READER_INF.AddOrUpdate(item);
            dtb.SaveChanges();

            Load_Data();
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

                dtb.READER_INF.AddOrUpdate(item);
                dtb.SaveChanges();

                Load_Data();
            }
        }

        private void button_Account_Click(object sender, EventArgs e)
        {
            READER_INF focused = (READER_INF)gridView_Reader.GetFocusedRow();
            feditAccount f = new feditAccount(focused.USERNAME, focused.PASSWORD);
            f.ShowDialog();
        }
    }
}
