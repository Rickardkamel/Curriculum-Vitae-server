using System.Collections.Generic;
using System.Web.Http;
using BusinessLogic.Handlers;
using Contracts;
using DataService;

namespace Curriculum_Vitae_server.Controllers
{
    public class ProjectController : ApiController
    {
        private readonly ProjectHandler _projectHandler;

        public ProjectController()
        {
            _projectHandler = new ProjectHandler(new DataContext());
        }

        public IEnumerable<ProjectContract> Get()
        {
            return _projectHandler.Get();
        }

        public IHttpActionResult Get(int id)
        {
            var project = _projectHandler.Get(id);
            return project == null ? (IHttpActionResult)NotFound() : Ok(project);
        }

        //public IHttpActionResult Post(ProjectContract projectContract)
        //{
        //    _projectHandler.Post(projectContract);
        //    return Ok();
        //}

        //public IHttpActionResult Delete(int id)
        //{
        //    _projectHandler.Delete(id);
        //    return Ok();
        //}
    }
}
