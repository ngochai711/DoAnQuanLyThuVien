using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQuanLyThuVien.DTO;
using System.Data.Entity;

namespace DoAnQuanLyThuVien
{
    public partial class fInfReader : DevExpress.XtraEditors.XtraForm
    {
        SHARED_LIBRARY_ENTITY dtb = new SHARED_LIBRARY_ENTITY();
        public fInfReader()
        {
            InitializeComponent();
        }

        private void fInfReader_Load(object sender, EventArgs e)
        {
            labelUsername.Text = "anhthy"; //label username
            var acc = dtb.READER_INF.Find(labelUsername.Text);

            if (acc.SEX.ToString() == "Nữ")
                radioBtnFemale.Checked = true;
            else if (acc.SEX.ToString() == "Nam")
                radioBtnMale.Checked = true;
            else radioBtnOther.Checked = true;

            dtpBirthDate.Value = acc.BIRTH.Value;
            tbxAge.Text = acc.AGE.ToString();
            tbxName.Text = acc.NAME; //textbox Họ và Tên
            tbxCMND.Text = acc.PID;
            tbxAddress.Text = acc.ADDRESS;
            tbxPhoneNum.Text = acc.PHONE;
            tbxEmail.Text = acc.EMAIL;
            picEAva.EditValue = acc.AVATAR;
        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {
            //if (tbxNewpass.Text != tbxConfirm.Text)
            //{
            //    MessageBox.Show("Vui lòng nhập lại đúng mật khẩu mới!", "Thông báo", MessageBoxButtons.OK);
            //}
            //else
            //{
            //    dtb.SaveChanges();
            //    MessageBox.Show("Bạn đã cập nhật thành công!", "Thông báo", MessageBoxButtons.OK);
            //}
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();

            if (o.ShowDialog() == DialogResult.OK)
            {
                byte[] i = null;
                FileStream f = new FileStream(o.FileName, FileMode.Open, FileAccess.Read);
                BinaryReader bi = new BinaryReader(f);
                i = bi.ReadBytes((int)f.Length);
                picEAva.EditValue = i;
            }
        }
    }
}