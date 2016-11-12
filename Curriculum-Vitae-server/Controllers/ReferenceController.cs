using System.Collections.Generic;
using System.Web.Http;
using BusinessLogic.Handlers;
using Contracts;
using DataService;

namespace Curriculum_Vitae_server.Controllers
{
    public class ReferenceController : ApiController
    {
        private readonly ReferenceHandler _referenceHandler;

        public ReferenceController()
        {
            _referenceHandler = new ReferenceHandler(new DataContext());
        }

        public IEnumerable<ReferenceContract> Get()
        {
            return _referenceHandler.Get();
        }

        public IHttpActionResult Get(int id)
        {
            var aboutMe = _referenceHandler.Get(id);
            return aboutMe == null ? (IHttpActionResult)NotFound() : Ok(aboutMe);
        }

        //public IHttpActionResult Post(ReferenceContract referenceContract)
        //{
        //    _referenceHandler.Post(referenceContract);
        //    return Ok();
        //}

        //public IHttpActionResult Delete(int id)
        //{
        //    _referenceHandler.Delete(id);
        //    return Ok();
        //}
    }
}
