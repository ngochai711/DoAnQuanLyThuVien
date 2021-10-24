using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DoAnQuanLyThuVien.DTO;

namespace DoAnQuanLyThuVien
{
    public partial class fAdd : DevExpress.XtraEditors.XtraForm
    {
        /*SqlConnection connection = null;
        string str = @"Data Source=.\SQLEXPRESS;Initial Catalog=LIBRARY_DATABASE;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        string gt;*/

        public fAdd()
        {
            InitializeComponent();
        }

        private void Them_Click(object sender, EventArgs e)
        {
            AddStaff();

            MessageBox.Show("Đã thêm thành công!", "Thông báo", MessageBoxButtons.OK);
            /*if (radioButton3.Checked == true)
            {
                gt = "Nam";
            }
            else
                gt = "Nữ";
            if (connection == null)
            {
                connection = new SqlConnection(str);
            }
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand();
            command.CommandText = "insert into STAFF_INFO(ID, NAME, AGE, SEX, POSITION, ADDRESS, PHONE_NUMBER, EMAIL) values ('01', N'" + HoTen.Text + "', '" + NgaySinh.Text + "', N'" + gt + "', '" + Chucvu.Text + "', N'" + Diachi.Text + "', '" + SDT.Text + "', '" + Mail.Text + "')";
            command.Connection = connection;
            int trave = command.ExecuteNonQuery();
            if (trave > 0)
            {
                DialogResult OK = MessageBox.Show("Đã thêm thành công!", "Thông báo", MessageBoxButtons.OK);
                if (OK == DialogResult.OK)
                    this.Close();
            }
            else
            {
                DialogResult OK = MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK);
                if (OK == DialogResult.OK)
                    this.Close();
            }*/
        }

        private void ava_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var Filenames = data as string[];
                if (Filenames.Length > 0)
                    ava.BackgroundImage = Image.FromFile(Filenames[0]);
            }
        }

        private void ADD_Load(object sender, EventArgs e)
        {
            ava.AllowDrop = true;
        }

        private void ava_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void Huy_Click(object sender, EventArgs e)
        {
            DialogResult yesno = MessageBox.Show("Bạn có thật sự muốn hủy?", "Thông báo", MessageBoxButtons.YesNo);
            if (yesno == DialogResult.Yes)
                this.Close();
        }


        private void tkdk_Enter(object sender, EventArgs e)
        {
            if (tkdk.Text == "Nhập Tài khoản")
            {
                tkdk.Text = "";
                tkdk.ForeColor = Color.White;
            }
        }

        private void tkdk_Leave(object sender, EventArgs e)
        {
            if (tkdk.Text == "")
            {
                tkdk.Text = "Nhập ID";
                tkdk.ForeColor = Color.Gray;
            }
        }

        private void mkdk_Enter(object sender, EventArgs e)
        {
            if (mkdk.Text == "Nhập Mật khẩu")
            {
                mkdk.Text = "";
                mkdk.ForeColor = Color.White;
            }
        }

        private void mkdk_Leave(object sender, EventArgs e)
        {
            if (mkdk.Text == "")
            {
                mkdk.Text = "Nhập Mật khẩu";
                mkdk.ForeColor = Color.Gray;
            }
        }

        private void HoTen_Enter(object sender, EventArgs e)
        {
            if (HoTen.Text == "Nhập Họ và Tên")
            {
                HoTen.Text = "";
                HoTen.ForeColor = Color.White;
            }
        }

        private void HoTen_Leave(object sender, EventArgs e)
        {
            if (HoTen.Text == "")
            {
                HoTen.Text = "Nhập Họ và Tên";
                HoTen.ForeColor = Color.Gray;
            }
        }

        private void NgaySinh_Enter(object sender, EventArgs e)
        {
            if (NgaySinh.Text == "DD/MM/YYYY")
            {
                NgaySinh.Text = "";
                NgaySinh.ForeColor = Color.White;
            }
        }

        private void NgaySinh_Leave(object sender, EventArgs e)
        {
            if (NgaySinh.Text == "")
            {
                NgaySinh.Text = "DD/MM/YYYY";
                NgaySinh.ForeColor = Color.Gray;
            }
        }

        private void Chucvu_Enter(object sender, EventArgs e)
        {
            if (Chucvu.Text == "Nhập Chức vụ")
            {
                Chucvu.Text = "";
                Chucvu.ForeColor = Color.White;
            }
        }

        private void Chucvu_Leave(object sender, EventArgs e)
        {
            if (Chucvu.Text == "")
            {
                Chucvu.Text = "Nhập Chức vụ";
                Chucvu.ForeColor = Color.Gray;
            }
        }

        private void Diachi_Enter(object sender, EventArgs e)
        {
            if (Diachi.Text == "Nhập Địa chỉ")
            {
                Diachi.Text = "";
                Diachi.ForeColor = Color.White;
            }
        }

        private void Diachi_Leave(object sender, EventArgs e)
        {
            if (Diachi.Text == "")
            {
                Diachi.Text = "Nhập Địa chỉ";
                Diachi.ForeColor = Color.Gray;
            }
        }

        private void SDT_Enter(object sender, EventArgs e)
        {
            if (SDT.Text == "Nhập SĐT")
            {
                SDT.Text = "";
                SDT.ForeColor = Color.White;
            }
        }

        private void SDT_Leave(object sender, EventArgs e)
        {
            if (SDT.Text == "")
            {
                SDT.Text = "Nhập SĐT";
                SDT.ForeColor = Color.Gray;
            }
        }

        private void Mail_Enter(object sender, EventArgs e)
        {
            if (Mail.Text == "Nhập Email")
            {
                Mail.Text = "";
                Mail.ForeColor = Color.White;
            }
        }

        private void Mail_Leave(object sender, EventArgs e)
        {
            if (Mail.Text == "")
            {
                Mail.Text = "Nhập Email";
                Mail.ForeColor = Color.Gray;
            }
        }

        private void AddStaff()
        {
            STAFF_DATABASE DTB = new STAFF_DATABASE();
            DateTime birth = DateTime.ParseExact(NgaySinh.Text, "dd/mm/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            string gender;
            bool role;

            if (radioButton3.Checked == true)
            {
                gender = "Nam";
            }
            else
                gender = "Nữ";

            if (Chucvu.Text == "NV")
            {
                role = false;
            }
            else
                role = true;

            DTB.STAFF_INFO.Add(new STAFF_INFO()
            {
                ID = tkdk.Text,
                NAME = HoTen.Text,
                ADDRESS = Diachi.Text,
                SEX = gender,
                BIRTHDATE = birth,
                PHONE_NUMBER = SDT.Text,
                EMAIL = Mail.Text,
                POSITION = role
            });

            DTB.SaveChanges();
        }
    }
}
