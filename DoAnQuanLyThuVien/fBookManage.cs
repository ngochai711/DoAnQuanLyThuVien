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

namespace DoAnQuanLyThuVien
{
    public partial class fBookManage : DevExpress.XtraEditors.XtraForm
    {
        public fBookManage()
        {
            InitializeComponent();
        }

        LIBRARY_DATABASEEntities db;

        private void fBookManage_Load(object sender, EventArgs e)
        {
            db = new LIBRARY_DATABASEEntities();
            db.BOOKS_MANAGEMENT.Load();
            bOOKSMANAGEMENTBindingSource.DataSource = db.BOOKS_MANAGEMENT.Local;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bOOKSMANAGEMENTBindingSource.AddNew();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa sách này hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                bOOKSMANAGEMENTBindingSource.RemoveCurrent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
            XtraMessageBox.Show("Bạn đã cập nhật thành công !","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var changed = db.ChangeTracker.Entries().Where(x => x.State != EntityState.Unchanged).ToList();
            foreach(var obj in changed)
            {
                switch(obj.State)
                {
                    case EntityState.Modified:
                        obj.CurrentValues.SetValues(obj.OriginalValues);
                        obj.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        obj.State = EntityState.Detached;
                        break;
                    case EntityState.Deleted:
                        obj.State = EntityState.Unchanged;
                        break;
                }
            }
            bOOKSMANAGEMENTBindingSource.ResetBindings(false);
        }

        private void btnLibBook_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dalcLibBook.Show();
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            this.Hide();
          
        }

        private void btnPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dalcLibBook.Hide();
        }
    }
}