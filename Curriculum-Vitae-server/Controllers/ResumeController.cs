using System.Collections.Generic;
using System.Web.Http;
using BusinessLogic.Handlers;
using Contracts;
using DataService;

namespace Curriculum_Vitae_server.Controllers
{
    public class ResumeController : ApiController
    {
        private readonly ResumeHandler _resumeHandler;

        public ResumeController()
        {
            _resumeHandler = new ResumeHandler(new DataContext());
        }

        public IEnumerable<ResumeContract> Get()
        {
            return _resumeHandler.Get();
        }

        public IHttpActionResult Get(int id)
        {
            var resume = _resumeHandler.Get(id);
            return resume == null ? (IHttpActionResult)NotFound() : Ok(resume);
        }

        //public IHttpActionResult Post(ResumeContract resumeContract)
        //{
        //    _resumeHandler.Post(resumeContract);
        //    return Ok();
        //}

        //public IHttpActionResult Delete(int id)
        //{
        //    _resumeHandler.Delete(id);
        //    return Ok();
        //}
    }
}
