using System.Collections.Generic;
using Contracts;
using DataService;
using DataService.UnitOfWork;
using Mappers;

namespace BusinessLogic.Handlers
{
    public class ReferenceHandler
    {
        private readonly UnitOfWork _uow;

        public ReferenceHandler(object dataContext)
        {
            _uow = new UnitOfWork((DataContext)dataContext);
        }

        public List<ReferenceContract> Get()
        {
            return _uow.ReferenceRepository.GetAll().ToContracts();
        }

        public ReferenceContract Get(int id)
        {
            return _uow.ReferenceRepository.Get(id).ToContract();
        }

        public void Post(ReferenceContract referenceContract)
        {
            _uow.ReferenceRepository.CreateOrUpdate(referenceContract.ToEntity());
        }

        public void Delete(int id)
        {
            _uow.ProjectRepository.Delete(id);
        }
    }
}
