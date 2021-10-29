using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DoAnQuanLyThuVien.DTO;

namespace DoAnQuanLyThuVien
{
    public partial class fBookManager : DevExpress.XtraEditors.XtraForm
    {
        public fBookManager()
        {
            InitializeComponent();
        }

        LIBRARY_DATABASEEntities db;
        

        private void fBookManager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lIBRARY_DATABASEDataSet.EBOOKS_MANAGEMENT' table. You can move, or remove it, as needed.
            this.eBOOKS_MANAGEMENTTableAdapter.Fill(this.lIBRARY_DATABASEDataSet.EBOOKS_MANAGEMENT);
            db = new LIBRARY_DATABASEEntities();
            db.BOOKS_MANAGEMENT.Load();
            bOOKSMANAGEMENTBindingSource.DataSource = db.BOOKS_MANAGEMENT.Local;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa sách này hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                bOOKSMANAGEMENTBindingSource.RemoveCurrent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bOOKSMANAGEMENTBindingSource.AddNew();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
            XtraMessageBox.Show("Bạn đã cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var changed = db.ChangeTracker.Entries().Where(x => x.State != EntityState.Unchanged).ToList();
            foreach (var obj in changed)
            {
                switch (obj.State)
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
    }
}