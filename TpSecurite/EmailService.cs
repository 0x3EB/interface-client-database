using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace TpSecurite
{
    class EmailService
    {
        /**
         * Send an email to the email in the parameters, with the code generate
         **/
        public EmailService(MailAddress emailTo, string strCode)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("sml.louisarmand@gmail.com");
            mail.To.Add(emailTo);
            mail.Subject = "EMAIL DE VERIFICATION - SML";
            mail.Body = "CODE DE VERIFICATION "+strCode;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("sml.louisarmand@gmail.com", "LouisarmandBTS2018");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

        } 
    }
}
