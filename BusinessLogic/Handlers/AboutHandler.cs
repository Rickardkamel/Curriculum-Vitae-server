using System.Collections.Generic;
using Contracts;
using DataService;
using DataService.UnitOfWork;
using Mappers;

namespace BusinessLogic.Handlers
{
    public class AboutHandler
    {
        private readonly UnitOfWork _uow;

        public AboutHandler(object dataContext)
        {
            _uow = new UnitOfWork((DataContext)dataContext);
        }

        public List<AboutContract> Get()
        {
            //return _uow.AboutRepository.Get().ToContracts();
            return _uow.AboutRepository.GetAll().ToContracts();
        }

        public AboutContract Get(int id)
        {
            return _uow.AboutRepository.Get(id).ToContract();
        }

        public void Post(AboutContract aboutContract)
        {
            _uow.AboutRepository.CreateOrUpdate(aboutContract.ToEntity());
        }

        public void Delete(int id)
        {
            _uow.AboutRepository.Delete(id);
        }
    }
}
