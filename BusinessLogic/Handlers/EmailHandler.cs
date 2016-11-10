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
                    Credentials = new NetworkCredential("rickardkamelautomail@gmail.com", "password"),
                    Host = "smtp.gmail.com",
                    EnableSsl = true,
                };
                mail.Subject = emailContract.Subject;

                mail.Body = emailContract.Message + " - - - -  SENT FROM: " + emailContract.From;
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
