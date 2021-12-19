using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyThuVien.DTO
{
    public class ReqCardInfo
    {
        public ReqCardInfo(int id, string req_id,int book_id,int num)
        {
            this.Id = id;
            this.Request_ID = req_id;
            this.Books_ID = book_id;
            this.Number = num;
        }

        public ReqCardInfo(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Request_ID = row["REQUEST_ID"].ToString();
            this.Books_ID = (int)row["BOOKS_ID"];
            this.Number = (int)row["NUMBER"];
        }

        private int id;
        private string request_ID;
        private int books_ID;
        private int number;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Request_ID
        {
            get
            {
                return request_ID;
            }

            set
            {
                request_ID = value;
            }
        }

        public int Books_ID
        {
            get
            {
                return books_ID;
            }

            set
            {
                books_ID = value;
            }
        }

        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }
    }
}
