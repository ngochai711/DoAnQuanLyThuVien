using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyThuVien.DTO
{
    public class Infomation
    {
        private string email;
        private string phonenumber;
        private string address;
        private DateTime bd;
        private string gen;
        private string finame;
        private string lastname;
        private string pass;
        private string username;

        public Infomation(string username, string pass, string lastname, string finame, string gen, DateTime bd, string address, string phonenumber, string email)
        {
            this.Username = username;
            this.Pass = pass;
            this.Lastname = lastname;
            this.Finame = finame;
            this.Gen = gen;
            this.Bd = bd;
            this.Address = address;
            this.Phonenumber = phonenumber;
            this.Email = email;
        }
        
        public Infomation(DataRow row)
        {
            this.Username = (string)row["USERNAME"];
            this.Pass = (string)row["PASSWORD"];
            this.Lastname = (string)row["LAST_NAME"];
            this.Finame = (string)row["FIRST_NAME"];
            this.Gen = (string)row["GENDER"];
            this.Bd = (DateTime)row["BIRTHDATE"];
            this.Address = (string)row["ADDRESS"];
            this.Phonenumber = (string)row["PHONE_NUMBER"];
            this.Email = (string)row["EMAIL"];
        }

        public string Username { get => username; set => username = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Finame { get => finame; set => finame = value; }
        public string Gen { get => gen; set => gen = value; }
        public DateTime Bd { get => bd; set => bd = value; }
        public string Address { get => address; set => address = value; }
        public string Phonenumber { get => phonenumber; set => phonenumber = value; }
        public string Email { get => email; set => email = value; }
    }
}
