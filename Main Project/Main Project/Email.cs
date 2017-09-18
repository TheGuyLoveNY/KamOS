using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;

namespace Main_Project
{
    public partial class Email : Form
    {

        public bool fileAttach = false;
        public Email()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                SmtpClient theClient = new SmtpClient("smtp.gmail.com",587);
                theClient.EnableSsl = true;
                theClient.Timeout = 100000;
                theClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                theClient.UseDefaultCredentials = false;
                theClient.Credentials = new NetworkCredential(userID.Text,_Password.Text);
                MailMessage msg = new MailMessage();
                
                msg.To.Add(senderEmail.Text);


                if(ccBox.Visible)
                    msg.CC.Add(ccBox.Text);

                if(bccBox.Visible)
                    msg.Bcc.Add(bccBox.Text);

                msg.From = new MailAddress(userID.Text);
                msg.Subject = _Subject.Text;
                msg.Body = _Body.Text;

                if (fileAttach)
                {
                    Attachment at = new Attachment(attachaLabel1.Text);
                    msg.Attachments.Add(at);
                }

                theClient.Send(msg);
                MessageBox.Show("Sent!");
            }

            catch (Exception ex)
            {
               // MessageBox.Show("If you were mailing from Gmail account, Please follow these steps below :\n1) Log in with your Gmail account.\n2) Open the following link: https://www.google.com/settings/security/lesssecureapps \n3) Choose “Turn on” to let less secure apps access your Google account.");
                MessageBox.Show(ex.Message);
            }


        }

        private void bccBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void attachButton_Click(object sender, EventArgs e)
        {
            fileAttach = true;
            OpenFileDialog fd = new OpenFileDialog();

            if (fd.ShowDialog() == DialogResult.OK)
            {
                attachaLabel1.Text = fd.FileName.ToString();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
              ccBox.Visible = checkBox1.Checked;    
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            bccBox.Visible = checkBox2.Checked;
        }
    }
}

/*
1) Log in with your Gmail account.

2) Open the following link: https://www.google.com/settings/security/lesssecureapps  

3) Choose “Turn on” to let less secure apps access your Google account.

    */