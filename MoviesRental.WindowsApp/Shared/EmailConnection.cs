using FluentEmail.Core;
using FluentEmail.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.WindowsApp.Shared
{
    public class EmailConnection
    {
        public async void SendEmailOffline(string CurrentEmail)
        {
            var sender = new SmtpSender(() => new SmtpClient("localhost")
            {
                EnableSsl = false,
                DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory,
                PickupDirectoryLocation = @"C:\Email"
            });

            Email.DefaultSender = sender;

            var email = await Email
                .From(emailAddress: "mvsrntl@gmail.com")
                .To(emailAddress: CurrentEmail)
                .Subject(subject: "Drugs")
                .Body(body: "Thanks for buiyng our products")
                .SendAsync();
        }

        public bool EmailFormatValidation(string email)
        {
            try
            {
                MailMessage mailMessage = new MailMessage("mvsrntl@gmail.com", email);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //Google no longer makes this option.

        public bool SendEmailOnline(string email, string name)
        {
            try
            {
                MailMessage mailMessage = new MailMessage("mvsrntl@gmail.com", email);
                mailMessage.Subject = $"Welcome {name} to Movies Rental application";
                mailMessage.IsBodyHtml = true;
                mailMessage.Body = "Welcome";
                mailMessage.SubjectEncoding = Encoding.UTF8;
                mailMessage.BodyEncoding = Encoding.UTF8;
                SmtpClient smtpClient = new SmtpClient("mvsrntl@gmail.com", 587);
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("mvsrntl@gmail.com", "Lucas0158");
                smtpClient.EnableSsl = true;
                smtpClient.Send(mailMessage);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }

            return false;
        }
    }
}
