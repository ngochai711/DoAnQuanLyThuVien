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
    public partial class fReader : Form
    {
        public fReader()
        {
            InitializeComponent();
            fBookList _bookList = new fBookList();
            _bookList.FormBorderStyle = FormBorderStyle.None;
            //BookList.backcolor = Color.FromArgb(245, 238, 220);

            openChildForm(_bookList);
        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {


            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm; 
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnEbookReading_Click(object sender, EventArgs e)
        {
            fEbookList _ebookList = new fEbookList();
            _ebookList.FormBorderStyle = FormBorderStyle.None;
            //BookList.backcolor = Color.FromArgb(245, 238, 220);
            
            openChildForm(_ebookList);
        }

        private void btnBookSearching_Click(object sender, EventArgs e)
        {
            fBookList _bookList = new fBookList();
            _bookList.FormBorderStyle = FormBorderStyle.None;
            //BookList.backcolor = Color.FromArgb(245, 238, 220);

            openChildForm(_bookList);
        }
    }


}
