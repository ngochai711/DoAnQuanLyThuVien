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

        STAFF_DATABASE DTB = new STAFF_DATABASE();

        private void fStaffManager_Load(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void DataLoad()
        {
            dtgStaffList.DataSource = DTB.STAFF_INFO.ToList();
        }

        private void AddBinding()
        {

        }

        private void AddStaff()
        {
            DTB.STAFF_INFO.Add(new STAFF_INFO() { ID = "12345", NAME = "Naruto", ADDRESS = "" });
        }

        private void DeleteStaff()
        {
            string ID = dtgStaffList.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString();

            STAFF_INFO person = DTB.STAFF_INFO.Find(ID);

            DTB.STAFF_INFO.Remove(person);
            DTB.SaveChanges();
        }

        private void EditStaff()
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStaff();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DeleteStaff();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}