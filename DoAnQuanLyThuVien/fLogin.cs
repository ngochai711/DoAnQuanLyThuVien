using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQuanLyThuVien.DTO;

namespace DoAnQuanLyThuVien
{
    public partial class fLogin : Form
    {
        private SHARED_LIBRARY_ENTITY dataBase = null;
        
        public fLogin()
        {
            InitializeComponent();
        }

        private void simpleButton_Login_Click(object sender, EventArgs e)
        {
            string encryptedPassword = Encrypt_Password();

            Check_loginInfo(USERNAMEtextEdit.Text, encryptedPassword);
        }

        private string Encrypt_Password()
        {
            byte[] password_byteArray = ASCIIEncoding.ASCII.GetBytes(PASSWORDtextEdit.Text);
            
            byte[] byte_hashedPassword = new MD5CryptoServiceProvider().ComputeHash(password_byteArray);

            string str_hashedPassword = "";

            foreach (byte item in byte_hashedPassword)
            {
                str_hashedPassword += item;
            }

            return str_hashedPassword;
        }

        private void Check_loginInfo(string _Username, string _encryptedPassword)
        {
            dataBase = new SHARED_LIBRARY_ENTITY();

            if (ISTAFFcheckEdit.Checked)
            {
                var Account = dataBase.STAFF_INF.Find(_Username);

                if (Account == null)
                { MessageBox.Show("Sai tên đăng nhập!"); return; }

                if (Account.PASSWORD != _encryptedPassword)
                { MessageBox.Show("Sai mật khẩu!"); return; }

                fMain f = new fMain(Account as STAFF_INF);

                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                var Account = dataBase.READER_INF.Find(_Username);

                if (Account == null)
                { MessageBox.Show("Sai tên đăng nhập!"); return; }

                if (Account.PASSWORD != _encryptedPassword)
                { MessageBox.Show("Sai mật khẩu!"); return; }

                fReader f = new fReader(Account as READER_INF);

                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }
    }
}
