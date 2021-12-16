using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyThuVien.DAO
{
    class AccountDAO
    {
        public static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public AccountDAO() { }

        public DataRow get_requiredAccount(string usrname, string pssword, bool type)
        {
            string query = "EXEC SP_GET_INFO_IF_ACCOUNT_ISVALID @USERNAME , @PASSWORD , @isSTAFF";

            DataTable result =  DataProvider.Instance.ExecuteQuery(query, new object[] { usrname, pssword, type });

            if (result.Rows.Count == 1)
                return result.Rows[0];

            return null;
        }

        public int update_readerAvatar(string usrname, byte[] binary_img)
        {
            string query = "UPDATE READER_INF SET AVATAR = @value WHERE USERNAME = @userName";

            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { binary_img, usrname });
        }

        public int update_staffAvatar(string usrname, byte[] binary_img)
        {
            string query = "UPDATE STAFF_INF SET AVATAR = @value WHERE USERNAME = @userName";

            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { binary_img, usrname });
        }
    }
}
