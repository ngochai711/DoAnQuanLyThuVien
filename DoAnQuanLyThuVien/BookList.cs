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
    public partial class BookList : DevExpress.XtraEditors.XtraForm
    {
        public BookList()
        {
            InitializeComponent();
        }
        LIBRARY_DATABASEEntities3 db3;
    

        private void BookList_Load(object sender, EventArgs e)
        {
            db3 = new LIBRARY_DATABASEEntities3();
            db3.EBOOKS_MANAGEMENT.Load();
            eBOOKSMANAGEMENTBindingSource.DataSource = db3.EBOOKS_MANAGEMENT.Local;
            gridView1.OptionsBehavior.Editable = false;
        }

       
    }
}