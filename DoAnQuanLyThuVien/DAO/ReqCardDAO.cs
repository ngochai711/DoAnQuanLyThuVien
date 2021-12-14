using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyThuVien.DAO
{
    public class ReqCardDAO
    {
        private static ReqCardDAO instance;

        public static ReqCardDAO Instance
        {
            get
            {
                if (instance == null)
                    instance =new ReqCardDAO();

                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private ReqCardDAO() { }

        public void InsertCard(string req_Id,string id, DateTime toDate)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBook @request_ID , @id , @due_Date", new object[] { req_Id, id, toDate });    
        }

        public int GetMaxIDReqCard()
        {
            int id = (int)DataProvider.Instance.ExecuteScalar("SELECT COUNT(REQUEST_ID) FROM dbo.REQUEST_FORM");
            return id <= 0 ? 1 : ++id;
        }

        public bool CheckID(string id)
        {
            if((int)DataProvider.Instance.ExecuteScalar("SELECT count(*) FROM dbo.CLIENT_INFO WHERE ID = '" + id+"'") > 0)
            {
                return true;
            }
            return false;
        }
    }
}
