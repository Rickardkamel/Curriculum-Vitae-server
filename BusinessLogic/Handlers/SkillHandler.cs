using System.Collections.Generic;
using System.Linq;
using Contracts;
using DataService;
using DataService.UnitOfWork;
using Mappers;

namespace BusinessLogic.Handlers
{
    public class SkillHandler
    {
        private readonly UnitOfWork _uow;

        public SkillHandler(object dataContext)
        {
            _uow = new UnitOfWork((DataContext)dataContext);
        }

        public List<SkillContract> Get()
        {
            return _uow.SkillRepository.GetAll().OrderByDescending(o => o.Percentage).ToList().ToContracts();
        }

        public SkillContract Get(int id)
        {
            return _uow.SkillRepository.Get(id).ToContract();
        }

        public void Post(SkillContract skillContract)
        {
            _uow.SkillRepository.CreateOrUpdate(skillContract.ToEntity());
        }

        public void Delete(int id)
        {
            _uow.SkillRepository.Delete(id);
        }
    }
}
