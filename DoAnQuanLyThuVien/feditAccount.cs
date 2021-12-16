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
    public partial class feditAccount : Form
    {
        private SHARED_LIBRARY_ENTITY dataBase = new SHARED_LIBRARY_ENTITY();

        public feditAccount(string userName, string passWord)
        {
            InitializeComponent();

            USERNAMETextEdit.Text = userName;

            var account = dataBase.READER_INF.Find(USERNAMETextEdit.Text);
            PASSWORDTextEdit.Text = account.PASSWORD;
            pictureEdit1.EditValue = account.AVATAR;

            if (account != null)
            {

            }
        }

        private void button_signIn_Click(object sender, EventArgs e)
        {
        }
    }
}
