using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DoAnQuanLyThuVien.DAO;
using DoAnQuanLyThuVien.DTO;

namespace DoAnQuanLyThuVien
{

    public partial class fCreateCardLendBook : DevExpress.XtraEditors.XtraForm
    {
        static int CardID;
        static int[] BookID;
        int count = 1;
        int reLoad = 0;
        LIBRARY_DATABASEEntities8 db8;
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
            deToDate.Text = "";
            lvBorrowBook.Items.Clear();

            LoadReqCard();
            //if (reLoad < 1)
            //{ CheckTypeButton();  reLoad++; }
        }

        private void LoadReqCard()
        {
            db8 = new LIBRARY_DATABASEEntities8();
            rEQUESTFORMBindingSource.DataSource = db8.REQUEST_FORM.ToList();
        }
        
        

        private void txbID_TextChanged(object sender, EventArgs e)
        {
            if (ReqCardDAO.Instance.CheckID(txbID.Text) == false)
            {
                lcNotice.Text = "Tài khoản này chưa được đăng ký!!!";
                lcNotice.ForeColor = Color.Red;
            }
            else
            {
                lcNotice.Text = "Tài khoản hợp lệ.";
                lcNotice.ForeColor = Color.Green;
            }
        }

        public bool CheckCard(string id)
        {
            string temp = ReqCardDAO.Instance.TakeStatusByID(id);
            
            if (String.Equals(temp,"Đã trả"))
                return true;
            return false;
        }

        private void gridView1_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {


            if (e.Column.FieldName == "Submit" && CheckCard((e.RowHandle + 1).ToString()))
            {

                e.RepositoryItem = btnChecked;
            }

            else if (e.Column.FieldName == "Submit" && !CheckCard((e.RowHandle + 1).ToString()))
            {
                e.RepositoryItem = btnSubmit;
            }
        }
        #endregion



        #region Button
        private void sbCreateLendCard_Click(object sender, EventArgs e)
        {
            
            ReqCardDAO.Instance.InsertCard(CardID.ToString(),txbID.Text,DateTime.Parse(deToDate.Text));
            for(int i = 1; i < count; i++)
            {
                ReqCardInfoDAO.Instance.InsertCardInfo(CardID.ToString(), BookID[i].ToString());
                ReqCardInfoDAO.Instance.UpdateBookRemain(BookID[i]);
            }
            count = 1;
            fCreateCardLendBook_Load(sender, e);
        }
        private void sbScanner_Click(object sender, EventArgs e)
        {
            if (count > 5)
            {
                XtraMessageBox.Show("Chỉ có thể mượn tối đa được 5 quyển sách cùng lúc!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
        }


        private void gridControl1_Load(object sender, EventArgs e)
        {
            
        }


        //Du an sau khi co thoi gian tim hieu hon
        private void btnSubmit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            
            if (XtraMessageBox.Show("Bạn đã chắc chắn toàn bộ sách trong phiếu mượn đã được trả ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string query = "UPDATE dbo.REQUEST_FORM SET STATUS = N'Đã trả' WHERE REQUEST_ID = " + (gridView1.GetFocusedRow() as REQUEST_FORM).REQUEST_ID;
                DataProvider.Instance.ExecuteNonQuery(query);
                fCreateCardLendBook_Load(sender, e);

                //Ta
                List<ReqCardInfo> list = ReqCardInfoDAO.Instance.TakeIDBook(gridView1.FocusedRowHandle.ToString());
                foreach (ReqCardInfo item in list)
                {
                    ReqCardInfoDAO.Instance.UpdateBookRemainAccept(item.Books_ID);
                }
            }
        }
        private void btnChecked_ButtonClick(object sender, ButtonPressedEventArgs e)
        {

            if (XtraMessageBox.Show("Bạn có chắc muốn hủy xác nhận không ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string query = "UPDATE dbo.REQUEST_FORM SET STATUS = N'Đang được mượn' WHERE REQUEST_ID = " + (gridView1.GetFocusedRow() as REQUEST_FORM).REQUEST_ID;
                DataProvider.Instance.ExecuteNonQuery(query);
                fCreateCardLendBook_Load(sender, e);

            }
        }

        #endregion


    }
}