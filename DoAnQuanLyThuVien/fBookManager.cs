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
        public SHARED_LIBRARY_ENTITY db = new SHARED_LIBRARY_ENTITY();

        public fBookManager()
        {
            InitializeComponent();
        }

       


        private void fBookManager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lIBRARY_DATABASEDataSet.EBOOKS_MANAGEMENT' table. You can move, or remove it, as needed.
            //tendephanbiet1 = fLogin.tendephanbiet;
            //db = new SHARED_LIBRARY_ENTITY();
            db.BOOKS_MANAGEMENT.Load();
            bOOKSMANAGEMENTBindingSource.DataSource = db.BOOKS_MANAGEMENT.Local;

            //db3 = new SHARED_LIBRARY_ENTITY();
            db.EBOOKS_MANAGEMENT.Load();
            eBOOKSMANAGEMENTBindingSource.DataSource = db.EBOOKS_MANAGEMENT.Local;
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
            db.SaveChanges();
            XtraMessageBox.Show("Bạn đã cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void btnCancelf_Click(object sender, EventArgs e)
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
            eBOOKSMANAGEMENTBindingSource.ResetBindings(false);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Pdf Files|*.pdf";


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                gridView2.SetFocusedRowCellValue("BOOK_URL", ofd.FileName);
                BOOK_URLTextEdit.Text = ofd.FileName;
            }
        }
        private void BOOKIMAGEPictureEditf_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif";
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
        private void btnRead_Click(object sender, EventArgs e)
        {
            int[] selectedRows = gridView1.GetSelectedRows();
            string filename = "";
            try
            {
                var temp = gridView1.GetRowCellValue(selectedRows[0], "BOOK_URL");
                if (temp == null)
                    throw new Exception("Sách chưa được cập nhật.");
                else filename = temp.ToString();

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);

                return;
            }
            System.Diagnostics.Process.Start(filename);
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
            try
            {
                db.SaveChanges();
                XtraMessageBox.Show("Bạn đã cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Vui lòng nhập tên sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
          
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
            o.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif";
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