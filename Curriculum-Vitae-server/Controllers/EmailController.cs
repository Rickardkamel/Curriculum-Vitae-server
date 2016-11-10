using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLogic.Handlers;
using Contracts;
using DataService;

namespace Curriculum_Vitae_server.Controllers
{
    public class EmailController : ApiController
    {
        private readonly EmailHandler _emailHandler;

        public EmailController()
        {
            _emailHandler = new EmailHandler(new DataContext());
        }

        public IHttpActionResult Post(EmailContract emailContract)
        {
            return _emailHandler.SendMail(emailContract) ? (IHttpActionResult) Ok() : BadRequest();
        }
    }
}
