using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using DataService;
using DataService.UnitOfWork;
using Mappers;
using Models;

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
