using FluentEmail.Core;
using FluentEmail.Smtp;
using System.Net;
using System.Net.Mail;

namespace MoviesRental.WindowsApp.Shared
{
    public class EmailConnection
    {
        public async void SendEmailOffline(string CurrentEmail, string name, string accessKey)
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
                .Subject(subject: name)
                .Body(body: accessKey)
                .SendAsync();
        }

        public void SendEmailCached()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo("C:\\Email");

            FileInfo[] TXTFiles = directoryInfo.GetFiles("*.eml");

            if (TXTFiles.Length != 0)
            {
                foreach (FileInfo TXTFile in TXTFiles) 
                {
                    FileStream fileStream = File.Open("C:\\Email\\" + TXTFile.Name, FileMode.Open, FileAccess.ReadWrite);

                    var mailMessage = MsgReader.Mime.Message.Load(fileStream);

                    string accessKey = System.Text.Encoding.Default.GetString(mailMessage.MessagePart.Body);

                    SendEmailOnline(mailMessage.Headers.To[0].ToString(),mailMessage.Headers.Subject,accessKey);

                    fileStream.Close();

                    FileInfo fileInfo = TXTFile;

                    fileInfo.Delete();
                }
            }
        }

        public bool isConnected()
        {
            try
            {
                string myAddress = "www.google.com";
                IPAddress[] addresslist = Dns.GetHostAddresses(myAddress);

                if (addresslist[0].ToString().Length > 6)
                {
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
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

        public bool SendEmailOnline(string email, string name, string accessKey)
        {
            try
            {
                string fromMail = "mvsrntl@gmail.com";
                string fromPassword = "qqvlkywlkyciohfu";

                MailMessage message = new MailMessage();
                message.From = new MailAddress(fromMail);
                message.Subject = $"Welcome {name}";
                message.To.Add(new MailAddress(email));
                message.Body = $"<html><body> Use your access key to access the application: {accessKey} </body></html>";
                message.IsBodyHtml = true;

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(fromMail, fromPassword),
                    EnableSsl = true,

                };

                smtpClient.Send(message);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
