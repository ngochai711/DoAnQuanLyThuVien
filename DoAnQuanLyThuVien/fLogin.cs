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
    public partial class fLogin : Form
    {
        private SHARED_LIBRARY_ENTITY dataBase = new SHARED_LIBRARY_ENTITY();
        
        public fLogin()
        {
            InitializeComponent();
        }

        private void simpleButton_Login_Click(object sender, EventArgs e)
        {
            Check_loginInfo();
        }

        private void Check_loginInfo()
        {
            if (ISTAFFcheckEdit.Checked)
            {
                var Account = dataBase.STAFF_INF.Find(USERNAMEtextEdit.Text);

                if (Account == null)
                { MessageBox.Show("Sai tên đăng nhập!"); return; }

                if (Account.PASSWORD != PASSWORDtextEdit.Text)
                { MessageBox.Show("Sai mật khẩu!"); return; }

                fMain f = new fMain(Account as STAFF_INF);

                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                var Account = dataBase.READER_INF.Find(USERNAMEtextEdit.Text);

                if (Account == null)
                { MessageBox.Show("Sai tên đăng nhập!"); return; }

                if (Account.PASSWORD != PASSWORDtextEdit.Text)
                { MessageBox.Show("Sai mật khẩu!"); return; }

                fReader f = new fReader(Account as READER_INF);

                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }
    }
}
