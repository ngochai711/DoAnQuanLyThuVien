using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DoAnQuanLyThuVien.DAO;
using DoAnQuanLyThuVien.DTO;

namespace DoAnQuanLyThuVien
{
    public partial class fReqCardInfo : DevExpress.XtraEditors.XtraForm
    {
        public string username;
        public string CardID;
        SHARED_LIBRARY_ENTITY db = new SHARED_LIBRARY_ENTITY();
        public fReqCardInfo()
        {
            InitializeComponent();
        }

        public void GetUserName(string temp)
        {
            username = temp;
        }

        public void GetRowCardID(string temp)
        {
            CardID = temp;
        }
        private void fReqCardInfo_Load(object sender, EventArgs e)
        {

            //Load User Information
            READER_INF item = db.READER_INF.Find(username);
            peImage.EditValue = item.AVATAR;
            lcName.Text = "Họ và tên:" + item.NAME;
            lcUserName.Text = "Tên đăng nhập: " + item.USERNAME;
            lcNumber.Text = "Số điện thoại: " + item.PHONE;

            //Load Req_info

            List<ReqCardInfo> list= ReqCardInfoDAO.Instance.TakeIDBook(CardID);
            
            columnHeader1.Width = 224;
            columnHeader2.Width = 182;
            columnHeader3.Width = 130;
            foreach(ReqCardInfo ite in list)
            {
                BOOKS_MANAGEMENT book_Name = db.BOOKS_MANAGEMENT.Find(ite.Books_ID);
                ListViewItem ls = new ListViewItem(book_Name.TITLE);
                ls.SubItems.Add(book_Name.AUTHOR);
                ls.SubItems.Add(ite.Number.ToString());
                lvCardInfo.Items.Add(ls);
            }
        }
    }
}