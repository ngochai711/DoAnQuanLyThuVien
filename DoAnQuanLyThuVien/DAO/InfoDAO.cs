using System;
using System.Collections.Generic;
using DoAnQuanLyThuVien.DTO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DoAnQuanLyThuVien.DAO
{
    public class InfoDAO
    {
        public static InfoDAO instance;

        public static InfoDAO Instance
        {
            get
            {
                if (instance == null) instance = new InfoDAO();
                return InfoDAO.instance;
            }
            private set
            {
                InfoDAO.instance = value;
            }
        }

        private InfoDAO()
        {
        }

        public List<Infomation> GetListInfo(string username)
        {
            List<Infomation> ListInfo = new List<Infomation>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM GUEST_ACCOUNT WHERE USERNAME LIKE '" + username + "'");
            foreach (DataRow item in data.Rows)
            {
                Infomation i = new Infomation(item);
                ListInfo.Add(i);
            }
            return ListInfo;
        }

        public bool EditInfo(string Username, string Pass, string LName, string FName, string NewPass, string Gen, DateTime BD, string Address, string SDT, string Email)
        {
            int Result = DataProvider.Instance.ExecuteNonQuery("exec USP_EditInfo @userName , @passWord , @lName , @fName , @newpassWord , @gen , @bd , @address , @phoneNumber , @email", new object[] { Username, Pass, LName, FName, NewPass, Gen, BD, Address, SDT, Email });
            return Result > 0;
        }
    }
}
