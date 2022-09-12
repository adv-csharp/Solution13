using System.Net;
using System.Net.Mail;

namespace _1_email_and_sms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        delegate int MyFunc(int a);

        List<int> MySelect2(int[] arr, MyFunc func)
        {
            var result = new List<int>();
            foreach (var a in arr)
            {
                result.Add(func(a));
            }
            return result;
        }


        private void buttonSend_Click(object sender, EventArgs e)
        {
            /*
             * Email install konim - exchange server,
             *  SMTP
             *  POP3
             *  IMAP
             *
             *  https://www.google.com/settings/security/lesssecureapps
             *
             */
            string username = "fad.csharp@gmail.com";
            string password = "!p*Dx#r!AE%TZtS3NEu42U3TG";


            var message = new MailMessage();
            message.Subject = textBoxSubject.Text;
            message.To.Add(textBoxTo.Text);
            message.Body = textBoxMEssage.Text;
            message.From = new MailAddress(username);
            message.IsBodyHtml = true;
            message.Attachments.Add(new Attachment("c:/1.txt"));

            var smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential(username, password);

            smtpClient.Send(message);
            MessageBox.Show("Success");
        }

        async private void   buttonSendSMS_Click(object sender, EventArgs e)
        {
            /*
             * SMS
             *  Modem GSM
             *  SMS Provider
             *  sms.ir
             *
             *
             *  RestSharp
             * httpClient
             */

            var username = "";
            var password = "";
            var lineNo = "";

            var httpClient = new HttpClient();
            await httpClient.PostAsync(
                $"https://ip.sms.ir/SendMessage.ashx?user={username}&pass={password}&text=khoshamadid&to={textBox1.Text}&lineNo={lineNo}",
                new StringContent(""));
        }
    }
}