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
    public partial class fReaderBorrowedBook : Form
    {
        public fReaderBorrowedBook()
        {
            InitializeComponent();
        }
        LIBRARY_DATABASEEntities6 db4;
        private void fReaderBorrowedBook_Load(object sender, EventArgs e)
        {
            db4 = new LIBRARY_DATABASEEntities6();
            //db4.REQUEST_INFO.Load();
            rEQUESTFORMBindingSource.DataSource = db4.REQUEST_FORM.ToList();
            gridView1.OptionsBehavior.Editable = false;
        }
    }
}
