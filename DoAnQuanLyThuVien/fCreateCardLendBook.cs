using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using DevExpress.XtraEditors;
using DoAnQuanLyThuVien.DAO;
using DoAnQuanLyThuVien.DTO;

namespace DoAnQuanLyThuVien
{

    public partial class fCreateCardLendBook : DevExpress.XtraEditors.XtraForm
    {
        static int CardID;
        static int[] BookID;
        int count = 1;
        public fCreateCardLendBook()
        {
            InitializeComponent();
        }
        #region Method
        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void labelControl8_Click(object sender, EventArgs e)
        {

        }


        private void fCreateCardLendBook_Load(object sender, EventArgs e)
        {
            txbCardCode.Text = ReqCardDAO.Instance.GetMaxIDReqCard().ToString();
            CardID = ReqCardDAO.Instance.GetMaxIDReqCard();
            BookID = new int[6];
            txbGuestName.Text = "";
            txbID.Text = "";
            txbPhoneNum.Text = "";
            lvBorrowBook.Items.Clear();
        }

        #endregion



        #region Button
        private void sbCreateLendCard_Click(object sender, EventArgs e)
        {
            ReqCardDAO.Instance.InsertCard(CardID.ToString(),txbID.Text,DateTime.Parse(deToDate.Text));
            for(int i = 1; i < count; i++)
            {
                ReqCardInfoDAO.Instance.InsertCardInfo(CardID.ToString(), BookID[i].ToString());
            }
            
            fCreateCardLendBook_Load(sender, e);
        }
        private void sbScanner_Click(object sender, EventArgs e)
        {
            if (count > 5)
            {
                MessageBox.Show("Chỉ có thể mượn tối đa được 5 quyển sách cùng lúc!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            fScanner f = new fScanner();
            f.ShowDialog();

            if (f.Id() != null)
            {
                List<BookListCard> listBook = BookListCardDAO.Instance.GetBookByID(f.Id());
                foreach (BookListCard item in listBook)
                {
                    ListViewItem lvItem = new ListViewItem(item.Title.ToString());
                    lvItem.SubItems.Add(item.Author.ToString());
                    lvItem.SubItems.Add("1");
                    lvBorrowBook.Items.Add(lvItem);
                }
                BookID[count] = f.Id();
                count++;
            }
        }

        #endregion

        private void txbID_TextChanged(object sender, EventArgs e)
        {
            if(ReqCardDAO.Instance.CheckID(txbID.Text)==false)
            {
                lcNotice.Text = "CMND/CCCD của độc giả hiện tại chưa được đăng ký";
                lcNotice.ForeColor = Color.Red;
            }
            else
            {
                lcNotice.Text = "Độc giả đã đăng ký tài khoản";
                lcNotice.ForeColor = Color.Green;
            }
        }
    }
}