using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQuanLyThuVien.DTO;

namespace DoAnQuanLyThuVien.DAO
{
    public class BookListCardDAO
    {
        private static BookListCardDAO instance;

        public static BookListCardDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BookListCardDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private BookListCardDAO() { }

        public List<BookListCard> GetBookByID(int id)
        {
            List<BookListCard> list = new List<BookListCard>();
            string query = "SELECT * FROM dbo.BOOKS_MANAGEMENT WHERE SERIAL_NUMBER = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                BookListCard book = new BookListCard(item);
                list.Add(book);
            }
            return list;
        }
    }
}
