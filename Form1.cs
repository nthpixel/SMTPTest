using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace SMTPHarness
{
    public partial class SMTPTestHarness : Form
    {
        public SMTPTestHarness()
        {
            InitializeComponent();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
			try
			{
				MailMessage mail = new MailMessage();
				mail.From = new MailAddress(txbFrom.Text);
				mail.To.Add(new MailAddress(txbTo.Text));
				mail.Subject = txbSubject.Text;
				mail.Body = txbBody.Text;
				mail.IsBodyHtml = cbxHtml.Checked;

				SmtpClient smtp = new SmtpClient();
				smtp.Host = txbServer.Text;
				smtp.Port = Convert.ToInt32(txbPort.Text);
				if (!String.IsNullOrEmpty(txbUserName.Text))
				{
					System.Net.NetworkCredential auth = new System.Net.NetworkCredential(txbUserName.Text, txbPassword.Text);
					smtp.Credentials = auth;
				}

				smtp.Send(mail);

				txbResult.Text = "Success";
			}
			catch (Exception ex)
			{
				txbResult.Text = ex.ToString();
			}
        }
    }
}
