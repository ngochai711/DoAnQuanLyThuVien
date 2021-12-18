using DoAnQuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Migrations;

namespace DoAnQuanLyThuVien
{
    public partial class fAccount : Form
    {
        private SHARED_LIBRARY_ENTITY dataBase = new SHARED_LIBRARY_ENTITY();
        private READER_INF account;

        private bool ischangingPass = false;

        public fAccount(string userName, string passWord)
        {
            InitializeComponent();

            account = dataBase.READER_INF.Find(userName);

            USERNAMETextEdit.Text = userName;
            PASSWORDTextEdit.Text = passWord;
        }

        private void hyperlinkLabelControl_changePass_Click(object sender, EventArgs e)
        {
            ischangingPass = !ischangingPass;

            layoutControlItem_newPass.ContentVisible = ischangingPass;
            layoutControlItem_reEnter.ContentVisible = ischangingPass;
            button_Save.Visible = ischangingPass;



            if (!ischangingPass)
            {
                PASSWORDTextEdit.Text = account.PASSWORD;

                ItemForPASSWORD.Text = "Mật khẩu";
                hyperlinkLabelControl_changePass.Text = "Mật khẩu mới";

                SuspendLayout();
                this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
                //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(490, 193);
                ResumeLayout(false);
            }
            else
            {
                NEWPASStextEdit.Text = "";
                REENTERtextEdit.Text = "";

                ItemForPASSWORD.Text = "Mật khẩu cũ";
                PASSWORDTextEdit.Text = "";
                hyperlinkLabelControl_changePass.Text = "Hủy";
                PASSWORDTextEdit.SelectAll();

                SuspendLayout();
                this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
                //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(490, 352);
                ResumeLayout(false);
            }

        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (PASSWORDTextEdit.Text == "")
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu cũ!");
                return;
            }

            if (PASSWORDTextEdit.Text != account.PASSWORD)
            {
                MessageBox.Show("Sai mật khẩu cũ!");
                return;
            }   

            if (NEWPASStextEdit.Text != REENTERtextEdit.Text)
            {
                MessageBox.Show("Mật khẩu mới không trùng khớp!");
                return;
            }

            try
            {
                account.PASSWORD = NEWPASStextEdit.Text;
                dataBase.READER_INF.AddOrUpdate(account);
                dataBase.SaveChanges();

                MessageBox.Show("Đổi mật khẩu thành công!");

                PASSWORDTextEdit.Text = account.PASSWORD;

                ItemForPASSWORD.Text = "Mật khẩu";
                hyperlinkLabelControl_changePass.Text = "Mật khẩu mới";

                ischangingPass = !ischangingPass;

                layoutControlItem_newPass.ContentVisible = ischangingPass;
                layoutControlItem_reEnter.ContentVisible = ischangingPass;
                button_Save.Visible = ischangingPass;

                SuspendLayout();
                this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
                //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(490, 193);
                ResumeLayout(false);
            }
            catch
            {
                MessageBox.Show("Mật khẩu mới không hợp lệ!");
            }
        }
    }
}
