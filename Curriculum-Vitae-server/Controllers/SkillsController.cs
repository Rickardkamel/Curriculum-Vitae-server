using System.Collections;
using System.Collections.Generic;
using System.Web.Http;
using BusinessLogic.Handlers;
using DataService;
using Contracts;

namespace Curriculum_Vitae_server.Controllers
{
    public class SkillsController : ApiController
    {
        private readonly SkillHandler _skillHandler;

        public SkillsController()
        {
            _skillHandler = new SkillHandler(new DataContext());
        }

        public IEnumerable<SkillContract> Get()
        {
            return _skillHandler.Get();
        }

        public IHttpActionResult Get(int id)
        {
            var skill = _skillHandler.Get(id);
            return skill == null ? (IHttpActionResult) NotFound() : Ok(skill);
        }

        public IHttpActionResult Post(SkillContract skillContract)
        {
            _skillHandler.Post(skillContract);
            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            _skillHandler.Delete(id);
            return Ok();
        }
    }
}
