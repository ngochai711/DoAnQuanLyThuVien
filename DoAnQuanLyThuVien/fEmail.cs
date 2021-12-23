using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLyThuVien
{
    public partial class fEmail : Form
    {
        public fEmail(string toAddress, string fromAddress)
        {
            InitializeComponent();

            Setup_Default_Values(toAddress, fromAddress);
        }



        //---Region_Controls_Events---
        #region ===============Controls_Events===============

        private void simpleButton_SEND_Click(object sender, EventArgs e)
        {
            string FromAddress = FROMADDRESStextEdit.Text;
            string ToAddress = TOADDRESStextEdit.Text;
            string Subject = SUBJECTtextEdit.Text;
            string Body = BODYrichTextBox.Text;

            Send_Gmail(FromAddress, ToAddress, Subject, Body);
        }

        #endregion ==========================================



        //---Region_Funcs_&_Procs---
        #region ================Funcs_&_Procs================

        private void Setup_Default_Values(string _toAddress, string _fromAddress)
        {
            FROMADDRESStextEdit.ReadOnly = true;

            FROMADDRESStextEdit.Text = _fromAddress;
            TOADDRESStextEdit.Text = _toAddress;
        }

        private void Send_Gmail(string _fromAddress, string _toAddress, string _Subject, string _Body)
        {
            try
            {
                MailAddress FromAddress = new MailAddress(_fromAddress);
                MailAddress ToAddress = new MailAddress(_toAddress);

                MailMessage mail_msg = new MailMessage(FromAddress, ToAddress);

                mail_msg.Subject = _Subject;
                mail_msg.Body = _Body;

                NetworkCredential Network_Credential = new NetworkCredential(FromAddress.Address, "shhcfjfpctmuctmu");

                SmtpClient smtp_client = new SmtpClient();

                smtp_client.Host = "smtp.gmail.com";
                smtp_client.Port = 587;
                smtp_client.EnableSsl = true;
                smtp_client.Credentials = Network_Credential;
                smtp_client.DeliveryMethod = SmtpDeliveryMethod.Network;

                smtp_client.Send(mail_msg);

                MessageBox.Show("Mail của bạn đã được gửi thành công!");
            }
            catch
            {
                MessageBox.Show("Địa chỉ mail không hợp lệ!");
            }
        }

        #endregion==========================================
    }
}
