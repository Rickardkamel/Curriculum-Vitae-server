using System.Collections.Generic;
using Contracts;
using DataService;
using DataService.UnitOfWork;
using Mappers;

namespace BusinessLogic.Handlers
{
    public class ProjectHandler
    {
        private readonly UnitOfWork _uow;

        public ProjectHandler(object dataContext)
        {
            _uow = new UnitOfWork((DataContext)dataContext);
        }

        public List<ProjectContract> Get()
        {
            return _uow.ProjectRepository.GetAll().ToContracts();
        }

        public ProjectContract Get(int id)
        {
            return _uow.ProjectRepository.Get(id).ToContract();
        }

        public void Post(ProjectContract projectContract)
        {
            _uow.ProjectRepository.CreateOrUpdate(projectContract.ToEntity());
        }

        public void Delete(int id)
        {
            _uow.ProjectRepository.Delete(id);
        }
    }
}
