using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyThuVien.DTO
{
    public class BookListCard
    {
        public BookListCard(int id, string catergory,string language,string title,string author,string publisher,int remain,int year,string note,string image)
        {
            this.Id = id;
            this.Catergory = catergory;
            this.Language = language;
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.Remain = remain;
            this.Year = year;
            this.Note = note;
            this.Image = image;
        }

        public BookListCard(DataRow row)
        {
            this.Id = (int)row["SERIAL_NUMBER"];
            this.Catergory = row["CATEGORY"].ToString();
            this.Language = row["language"].ToString();
            this.Title = row["title"].ToString();
            this.Author = row["author"].ToString();
            this.Publisher = row["publisher"].ToString();
            this.Remain = (int)row["remain"];
            this.Year = (int)row["YEAROFPUB"];
            this.Note = row["note"].ToString();
            this.Image = row["BOOKIMAGE"].ToString();
        }

        private int id;
        private string catergory;
        private string language;
        private string title;
        private string author;
        private string publisher;
        private int remain;
        private int year;
        private string note;
        private string image;

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

        public string Catergory
        {
            get
            {
                return catergory;
            }

            set
            {
                catergory = value;
            }
        }

        public string Language
        {
            get
            {
                return language;
            }

            set
            {
                language = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }

            set
            {
                author = value;
            }
        }

        public string Publisher
        {
            get
            {
                return publisher;
            }

            set
            {
                publisher = value;
            }
        }

        public int Remain
        {
            get
            {
                return remain;
            }

            set
            {
                remain = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        public string Note
        {
            get
            {
                return note;
            }

            set
            {
                note = value;
            }
        }

        public string Image
        {
            get
            {
                return image;
            }

            set
            {
                image = value;
            }
        }
    }
}
