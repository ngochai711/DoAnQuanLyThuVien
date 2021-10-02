using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQuanLyThuVien.DAO;

namespace DoAnQuanLyThuVien
{
    public partial class fBookManager : Form
    {
        public fBookManager()
        {
            InitializeComponent();
            LoadInfoBook();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            fMain f = new fMain();
            this.Hide();
            f.ShowDialog();
        }

        void LoadInfoBook()
        {
            ucListBook[] listBooks = new ucListBook[10];

            for(int i = 1; i < listBooks.Length; i++)
            {
                listBooks[i] = new ucListBook();
                if (flpListBook.Controls.Count < 0)
                    flpListBook.Controls.Clear();
                else
                    flpListBook.Controls.Add(listBooks[i]);
            }
        }
    }
}
