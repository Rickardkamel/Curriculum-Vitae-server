using System.Collections.Generic;
using System.Web.Http;
using BusinessLogic.Handlers;
using Contracts;
using DataService;

namespace Curriculum_Vitae_server.Controllers
{
    public class TimeStampController : ApiController
    {
        private readonly TimeStampHandler _timeStampHandler;

        public TimeStampController()
        {
            _timeStampHandler = new TimeStampHandler(new DataContext());
        }

        public IEnumerable<TimeStampContract> Get()
        {
            return _timeStampHandler.Get();
        }

        public IHttpActionResult Get(int id)
        {
            var timeStamp = _timeStampHandler.Get(id);
            return timeStamp == null ? (IHttpActionResult)NotFound() : Ok(timeStamp);
        }

        public IHttpActionResult Post(TimeStampContract timeStampContract)
        {
            _timeStampHandler.Post(timeStampContract);
            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            _timeStampHandler.Delete(id);
            return Ok();
        }
    }
}
