using DoAnQuanLyThuVien.DAO;
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
        READER_INF _INF;
        public fReaderBorrowedBook(READER_INF _INF1)
        {
            InitializeComponent();
            _INF = _INF1;
        }
        SHARED_LIBRARY_ENTITY db4;
        private void fReaderBorrowedBook_Load(object sender, EventArgs e)
        {

            //db4.REQUEST_INFO.Load();
            DataTable dataTable = ReqCardDAO.Instance.TakeReqFormTable(_INF.USERNAME);
            
            gridControl1.DataSource = dataTable;
           

            
            gridView1.OptionsBehavior.Editable = false;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            fReqCardInfo f = new fReqCardInfo();
            f.GetUserName(_INF.USERNAME);
            f.GetRowCardID(gridView1.GetRowCellValue(gridView1.FocusedRowHandle,"REQUEST_ID").ToString());
            f.ShowDialog();
        }
    }
}
