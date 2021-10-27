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
            db.STAFF_ACCOUNT.Load();
            gcv_StaffAcc.DataSource = db.STAFF_ACCOUNT.Local;
        }
        #endregion

        #region events
        #endregion
    }
}