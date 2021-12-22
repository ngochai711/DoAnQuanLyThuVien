using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQuanLyThuVien.DTO;

namespace DoAnQuanLyThuVien.DAO
{
    public class ReqCardInfoDAO
    {
        private static ReqCardInfoDAO instance;

        public static ReqCardInfoDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ReqCardInfoDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private ReqCardInfoDAO() { }    
        public void InsertCardInfo(string req_Id, string id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBookInfo @req_id , @book_id", new object[] { req_Id, id });
        }
        public void UpdateBookRemain(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.BOOKS_MANAGEMENT SET REMAIN-=1 WHERE SERIAL_NUMBER = " + id);
        }
        public void UpdateBookRemainAccept(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.BOOKS_MANAGEMENT SET REMAIN += 1 WHERE SERIAL_NUMBER = " + id);
        }

        //public List<ReqCardInfo> TakeIDBook(string id)
        //{
        //    List<ReqCardInfo> list = new List<ReqCardInfo>();
        //    DataTable table = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.REQUEST_INFO WHERE REQUEST_ID = " +id);
        //    foreach(DataRow item in table.Rows)
        //    {
        //        ReqCardInfo reqCard = new ReqCardInfo(item);
        //        list.Add(reqCard);
        //    }
        //    return list;
        //}
    }
}
