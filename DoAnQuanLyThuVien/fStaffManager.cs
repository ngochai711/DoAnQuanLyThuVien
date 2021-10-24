using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQuanLyThuVien.DTO;

namespace DoAnQuanLyThuVien
{
    public partial class fStaffManager : DevExpress.XtraEditors.XtraForm
    {
        public fStaffManager()
        {
            InitializeComponent();
        }

        private void fStaffManager_Load(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void DataLoad()
        {
            STAFF_DATABASE DTB = new STAFF_DATABASE();
            dtgStaffList.DataSource = DTB.STAFF_INFO.ToList();
        }

        private void AddStaff()
        {

        }

        private void DeleteStaff()
        {

        }

        private void EditStaff()
        {

        }
    }
}