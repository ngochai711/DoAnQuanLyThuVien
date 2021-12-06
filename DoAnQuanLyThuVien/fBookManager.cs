using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
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
        LIBRARY_DATABASEEntities3 db3;


        private void fBookManager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lIBRARY_DATABASEDataSet.EBOOKS_MANAGEMENT' table. You can move, or remove it, as needed.

            db = new LIBRARY_DATABASEEntities();
            db.BOOKS_MANAGEMENT.Load();
            bOOKSMANAGEMENTBindingSource.DataSource = db.BOOKS_MANAGEMENT.Local;

            db3 = new LIBRARY_DATABASEEntities3();
            db3.EBOOKS_MANAGEMENT.Load();
            eBOOKSMANAGEMENTBindingSource.DataSource = db3.EBOOKS_MANAGEMENT.Local;
            gridView2.OptionsBehavior.Editable = false;
        }

        #region PDF
        private void simpleButton1f_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa sách này hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                eBOOKSMANAGEMENTBindingSource.RemoveCurrent();
        }

        
        private void btnAddf_Click(object sender, EventArgs e)
        {
            eBOOKSMANAGEMENTBindingSource.AddNew();
        }


        private void btnEditf_Click(object sender, EventArgs e)
        {
            db3.SaveChanges();
            XtraMessageBox.Show("Bạn đã cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void btnCancelf_Click(object sender, EventArgs e)
        {
            var changed = db3.ChangeTracker.Entries().Where(x => x.State != EntityState.Unchanged).ToList();
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
            eBOOKSMANAGEMENTBindingSource.ResetBindings(false);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
          
            if (o.ShowDialog() == DialogResult.OK)
            {
                gridView2.SetFocusedRowCellValue("BOOK_URL", o.FileName);
                BOOK_URLTextEdit.Text = o.FileName;
            }
        }
        private void BOOKIMAGEPictureEditf_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            if (o.ShowDialog() == DialogResult.OK)
            {
                byte[] img = null;
                FileStream fs = new FileStream(o.FileName, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                gridView2.SetFocusedRowCellValue("IMAGES", img);
                IMAGESPictureEdit.EditValue = img;
            }
        }
        #endregion

        #region LibBook
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            bOOKSMANAGEMENTBindingSource.AddNew();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa sách này hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                bOOKSMANAGEMENTBindingSource.RemoveCurrent();
            db.SaveChanges();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
            XtraMessageBox.Show("Bạn đã cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
 

        private void btnCancel_Click_1(object sender, EventArgs e)
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

        private void BOOKIMAGEPictureEdit_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            if (o.ShowDialog() == DialogResult.OK)
            {
                byte[] img = null;
                FileStream fs = new FileStream(o.FileName, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                gridView1.SetFocusedRowCellValue("IMAGES", img);
                peImage.EditValue = img;
            }
        }

        #endregion


    }
}