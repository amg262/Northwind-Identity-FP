using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Identity.Email
{
    public class EmailHelper
    {
        public bool SendEmail(string userEmail, string confirmationLink)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("care@yogihosting.com");
            mailMessage.To.Add(new MailAddress(userEmail));

            mailMessage.Subject = "Confirm your email";
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = confirmationLink;

            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("info@rainpuddleslabradoodles.com", "Mydoodles!");
            client.Host = "smtpout.secureserver.net";
            client.Port = 80;

            try
            {
                client.Send(mailMessage);
                return true;
            }
            catch (Exception ex)
            {
                // log exception
                Console.WriteLine(ex);
            }
            return false;
        }

        // public bool SendEmailPasswordReset(string userEmail, string link)
        // {
        //     MailMessage mailMessage = new MailMessage();
        //     mailMessage.From = new MailAddress("care@yogihosting.com");
        //     mailMessage.To.Add(new MailAddress(userEmail));

        //     mailMessage.Subject = "Password Reset";
        //     mailMessage.IsBodyHtml = true;
        //     mailMessage.Body = link;

        //     SmtpClient client = new SmtpClient();
        //     client.Credentials = new System.Net.NetworkCredential("info@rainpuddleslabradoodles.com", "Mydoodles!");
        //     client.Host = "smtpout.secureserver.net";
        //     client.Port = 80;

        //     try
        //     {
        //         client.Send(mailMessage);
        //         return true;
        //     }
        //     catch (Exception ex)
        //     {
        //         // log exception
        //     }
        //     return false;
        // }
        public bool SendEmailPasswordReset(string userEmail, string link)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("northwindfp.help@gmail.com");
            mailMessage.To.Add(new MailAddress(userEmail));
 
            mailMessage.Subject = "Password Reset";
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = link;
 
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("northwindfp.help@gmail.com", "Qc#rXTVF6@2WNpf");
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.Timeout = 20000;
            mailMessage.Priority = MailPriority.High;
            try
            {
                client.Send(mailMessage);
                return true;
            }
            catch (Exception ex)
            {
                // log exception
                Console.WriteLine(ex);
            }
            return false;
        }

        public bool SendEmailTwoFactorCode(string userEmail, string code)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("care@yogihosting.com");
            mailMessage.To.Add(new MailAddress(userEmail));

            mailMessage.Subject = "Two Factor Code";
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = code;

            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("info@rainpuddleslabradoodles.com", "Mydoodles!");
            client.Host = "smtpout.secureserver.net";
            client.Port = 80;

            try
            {
                client.Send(mailMessage);
                return true;
            }
            catch (Exception ex)
            {
                // log exception
                Console.WriteLine(ex);
            }
            return false;
        }
    }
}
