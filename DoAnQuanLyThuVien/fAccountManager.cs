using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DoAnQuanLyThuVien.DTO;
using DevExpress.XtraGrid.Views.Base;

namespace DoAnQuanLyThuVien
{
    public partial class fAccountManager : DevExpress.XtraEditors.XtraForm
    {
        LIBRARY_DATABASEEntities db;

        public fAccountManager()
        {
            InitializeComponent();
        }

        #region methods
        private void LoadData()
        {
            db = new LIBRARY_DATABASEEntities();
            sTAFFACCOUNTBindingSource.DataSource = db.STAFF_ACCOUNT.ToList();
        }
        #endregion

        #region events
        private void fAccountManager_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (db.SaveChanges() == 1)
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK);
            };
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa thông tin này?", "Thông báo", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                STAFF_ACCOUNT item = sTAFFACCOUNTBindingSource.Current as STAFF_ACCOUNT;
                db.Entry<STAFF_ACCOUNT>(item).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                sTAFFACCOUNTBindingSource.RemoveCurrent();
            }    
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            faddinfo f = new faddinfo();
            f.ShowDialog();
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}