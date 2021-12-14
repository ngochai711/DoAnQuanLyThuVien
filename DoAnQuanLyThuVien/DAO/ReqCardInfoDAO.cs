using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
