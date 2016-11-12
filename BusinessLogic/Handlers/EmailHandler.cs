using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using DataService;
using DataService.UnitOfWork;

namespace BusinessLogic.Handlers
{
    public class EmailHandler
    {
        private readonly UnitOfWork _uow;

        public EmailHandler(object dataContext)
        {
            _uow = new UnitOfWork((DataContext)dataContext);
        }


        public bool SendMail(EmailContract emailContract)
        {
            try
            {
                MailMessage mail = new MailMessage("rickardkamelautomail@gmail.com", "rickardkamel@gmail.com");
                SmtpClient client = new SmtpClient
                {
                    Port = 587,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("rickardkamelautomail@gmail.com", "testPW123"),
                    Host = "smtp.gmail.com",
                    EnableSsl = true,
                };
                mail.Subject = emailContract.Subject;
                mail.Sender = new MailAddress(emailContract.Email);
                mail.Body = emailContract.Name + " contacted you through your website \n\n\n" + 
                    "Subject: " + emailContract.Subject + " \n" +  
                    "Message: " + emailContract.Message + "\n\n\nSenders email: " + emailContract.Email;
                client.Send(mail);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }


        }
    }
}
