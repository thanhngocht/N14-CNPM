using System.Net.Mail;
using System.Net;

namespace THE_COOKY_APP.DAO
{
    internal class EmailAuto
    {
        private string sender = "thanhngocbao0304@gmail.com";
        private string receiver;
        private string password = "sbkw dnkr imlk faku"; // Sử dụng mật khẩu ứng dụng nếu cần
        private string topic;
        private string content;

        public EmailAuto()
        {
            this.receiver = "";
            this.topic = "";
            this.content = "";
        }

        public EmailAuto(string receiver, string topic, string content)
        {
            this.receiver = receiver;
            this.topic = topic;
            this.content = content;
        }

        public void Letter(string html = null)
        {


            // Tạo và cấu hình đối tượng MailMessage
            MailMessage mail = new MailMessage();
            mail.To.Add(receiver);
            mail.From = new MailAddress(sender);
            mail.Subject = topic;
            mail.Body = content;
            mail.IsBodyHtml = !string.IsNullOrEmpty(html);

            // Cấu hình SmtpClient và gửi email
            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
            {
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential(sender, password);
                smtp.Send(mail);
            }


        }

    }
}
