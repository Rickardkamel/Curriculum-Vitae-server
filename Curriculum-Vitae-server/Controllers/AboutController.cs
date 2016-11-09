using System.Collections.Generic;
using System.Web.Http;
using BusinessLogic.Handlers;
using Contracts;
using DataService;

namespace Curriculum_Vitae_server.Controllers
{
    public class AboutController : ApiController
    {
        private readonly AboutHandler _aboutHandler;

        public AboutController()
        {
            _aboutHandler = new AboutHandler(new DataContext());
        }

        public IEnumerable<AboutContract> Get()
        {
            return _aboutHandler.Get();
        }

        public IHttpActionResult Get(int id)
        {
            var aboutMe = _aboutHandler.Get(id);
            return aboutMe == null ? (IHttpActionResult)NotFound() : Ok(aboutMe);
        }

        public IHttpActionResult Post(AboutContract aboutContract)
        {
            _aboutHandler.Post(aboutContract);
            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            _aboutHandler.Delete(id);
            return Ok();
        }
    }
}
