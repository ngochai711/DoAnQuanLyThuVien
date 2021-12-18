using DoAnQuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLyThuVien
{
    public partial class fnewAccount : Form
    {
        private SHARED_LIBRARY_ENTITY dataBase = new SHARED_LIBRARY_ENTITY();

        public fnewAccount()
        {
            InitializeComponent();
        }

        private void button_signIn_Click(object sender, EventArgs e)
        {
            string userName = USERNAMETextEdit.Text;
            string passWord = PASSWORDTextEdit.Text;
            string name = NAMEtextEdit.Text;
            string rePass = REPASStextEdit.Text;

            if (userName == "")
            {
                DialogResult emptyUsername = MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (passWord != rePass)
            {
                DialogResult unmatchedPass = MessageBox.Show("Mật khẩu không trùng khớp!");
                return;
            }

            try
            {
                READER_INF item = new READER_INF(userName, passWord, name);

                dataBase.READER_INF.Add(item);
                dataBase.SaveChanges();

                this.DialogResult = DialogResult.OK;

                this.Close();
            }
            catch
            {
                DialogResult duplicatedusername = MessageBox.Show("tài khoản đã tồn tại!");
            }
        }
    }
}
