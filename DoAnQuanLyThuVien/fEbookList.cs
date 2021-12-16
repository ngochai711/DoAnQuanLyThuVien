using DevExpress.XtraEditors;
using DoAnQuanLyThuVien.DTO;
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

namespace DoAnQuanLyThuVien
{
    public partial class fEbookList : DevExpress.XtraEditors.XtraForm
    {
        public fEbookList()
        {
            InitializeComponent();
        }
        SHARED_LIBRARY_ENTITY db3;
    

        private void BookList_Load(object sender, EventArgs e)
        {
            db3 = new SHARED_LIBRARY_ENTITY();
            db3.EBOOKS_MANAGEMENT.Load();
            eBOOKSMANAGEMENTBindingSource.DataSource = db3.EBOOKS_MANAGEMENT.Local;
            gridView1.OptionsBehavior.Editable = false;
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
            catch(Exception a )
            {
                MessageBox.Show(a.Message);
                
                return;
            }
            System.Diagnostics.Process.Start(filename);
        }
    }
}