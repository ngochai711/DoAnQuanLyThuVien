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
    public partial class fBookList : Form
    {
        public fBookList()
        {
            InitializeComponent();
        }

        SHARED_LIBRARY_ENTITY db3;

        private void fBookList_Load(object sender, EventArgs e)
        {
            db3 = new SHARED_LIBRARY_ENTITY();
            db3.BOOKS_MANAGEMENT.Load();
            bOOKSMANAGEMENTBindingSource.DataSource = db3.BOOKS_MANAGEMENT.Local;
            gridView11.OptionsBehavior.Editable = false;
        }
    }
}
