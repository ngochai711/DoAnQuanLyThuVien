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
using System.Data.Entity.Migrations;

namespace DoAnQuanLyThuVien
{
    public partial class fReaderAccount : Form
    {
        public fReaderAccount(string _userName)
        {
            InitializeComponent();

            USERNAMETextEdit.Text = _userName;
            PASSWORDTextEdit.Text = "123456789";
        }
    }
}
