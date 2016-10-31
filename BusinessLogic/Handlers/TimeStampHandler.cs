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
    public class TimeStampHandler
    {
        private readonly UnitOfWork _uow;

        public TimeStampHandler(object dataContext)
        {
            _uow = new UnitOfWork((DataContext)dataContext);
        }

        public List<TimeStampContract> Get()
        {
            return _uow.TimeStampRepository.GetAll().OrderBy(o => o.FromDate).ToList().ToContracts();
        }

        public TimeStampContract Get(int id)
        {
            return _uow.TimeStampRepository.Get(id).ToContract();
        }

        public void Post(TimeStampContract timeStampContract)
        {
            _uow.TimeStampRepository.CreateOrUpdate(timeStampContract.ToEntity());
        }

        public void Delete(int id)
        {
            _uow.TimeStampRepository.Delete(id);
        }
    }
}
