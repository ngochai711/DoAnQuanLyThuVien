using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyThuVien.DTO
{
    public class ReqCard
    {
        public ReqCard(string reqID,string userID,DateTime reqDate,DateTime dueDate,string status)
        {
            this.Req_ID = reqID;
            this.User_ID = userID;
            this.Req_Date = reqDate;
            this.DueDate = dueDate;
            this.Status = status;
        }

        public ReqCard(DataRow row)
        {
            this.Req_ID = row["REQUEST_ID"].ToString();
            this.User_ID = row["USERID"].ToString();
            this.Req_Date = (DateTime)row["REQUEST_DATE"];
            this.DueDate = (DateTime)row["DUE_DATE"];
            this.Status = row["STATUS"].ToString();
        }


        private string  req_ID;
        private string user_ID;
        private DateTime req_Date;
        private DateTime dueDate;
        private string status;

        public string Req_ID
        {
            get
            {
                return req_ID;
            }

            set
            {
                req_ID = value;
            }
        }

        public string User_ID
        {
            get
            {
                return user_ID;
            }

            set
            {
                user_ID = value;
            }
        }

        public DateTime Req_Date
        {
            get
            {
                return req_Date;
            }

            set
            {
                req_Date = value;
            }
        }

        public DateTime DueDate
        {
            get
            {
                return dueDate;
            }

            set
            {
                dueDate = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }
    }
}
