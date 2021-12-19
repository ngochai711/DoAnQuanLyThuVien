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
using DoAnQuanLyThuVien.DAO;

namespace DoAnQuanLyThuVien
{
    public partial class fLogin : Form
    {
        public static SHARED_LIBRARY_ENTITY tendephanbiet = new SHARED_LIBRARY_ENTITY();
        public fLogin()
        {
            InitializeComponent();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            string userName = textBox_Username.Text;
            string passWord = textBox_Password.Text;
            bool isStaff = checkBox_isStaff.Checked;

            activeAccountDTO validAccount = get_validAccount(userName, passWord, isStaff);

            if (validAccount == null)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
            else
            {
                Form f = null;

                if (isStaff)
                    f = new fMain(validAccount as STAFF_INF);
                else
                    f = new fReader(validAccount);

                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }

        private activeAccountDTO get_validAccount(string userName, string passWord, bool isStaff)
        {
            activeAccountDTO validAccount = null;

            DataRow result = AccountDAO.Instance.get_requiredAccount(userName, passWord, isStaff);

            if (result != null)
                get_accountData(ref validAccount, result, isStaff);

            return validAccount;
        }

        private void get_accountData(ref activeAccountDTO validAccount, DataRow dataSource, bool isStaff)
        {
            if (isStaff)
                validAccount = new STAFF_INF(dataSource);
            else
                validAccount = new READER_INF(dataSource);
        }
    }
}
