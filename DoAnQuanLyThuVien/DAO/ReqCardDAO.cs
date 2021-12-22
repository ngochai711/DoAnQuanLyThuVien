using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQuanLyThuVien.DTO;

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

        public int GetBookNumByReqID(string req_Id)
        {
            return (int)DataProvider.Instance.ExecuteScalar("SELECT COUNT(BOOKS_ID) FROM dbo.REQUEST_INFO WHERE REQUEST_ID ="+req_Id);
        }

        public bool CheckID(string id)
        {
            if((int)DataProvider.Instance.ExecuteScalar("SELECT count(*) FROM dbo.READER_INF WHERE USERNAME = '" + id+"'") > 0)
            {
                return true;
            }
            return false;
        }
        public string TakeStatusByID(string id)
        {
            string temp="";
            DataTable table = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.REQUEST_FORM WHERE REQUEST_ID = '" + id + "'");
            foreach(DataRow item in table.Rows)
            {
                //ReqCard rq = new ReqCard(item);
                //temp = rq.Status;
            }
            return temp;

        }
    }
}
