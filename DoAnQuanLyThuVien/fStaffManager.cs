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
            DTB.STAFF_INFO.DefaultIfEmpty();
            dtgStaffList.DataSource = DTB.STAFF_INFO.ToList();
        }

        private void AddBinding()
        {

        }

        private void DeleteStaff()
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa?", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            string ID = dtgStaffList.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString();

            STAFF_INFO person = DTB.STAFF_INFO.Find(ID);

            DTB.STAFF_INFO.Remove(person);
            DTB.SaveChanges();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAdd f = new fAdd();

            f.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            STAFF_DATABASE dtb = new STAFF_DATABASE();
            dtgStaffList.DataSource = dtb.STAFF_INFO.ToList();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DeleteStaff();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DTB.SaveChanges();
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            TextBox search = sender as TextBox;

            using(STAFF_DATABASE stfin4 = new STAFF_DATABASE())
            {
                var result = from dtb in stfin4.STAFF_INFO
                             where (dtb.NAME.Contains(search.Text))
                            select dtb;
                dtgStaffList.DataSource = result.ToList();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }
    }
}