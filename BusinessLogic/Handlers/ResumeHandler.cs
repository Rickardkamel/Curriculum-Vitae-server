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
    public class ResumeHandler
    {
        private readonly UnitOfWork _uow;

        public ResumeHandler(object dataContext)
        {
            _uow = new UnitOfWork((DataContext)dataContext);
        }

        public IList<ResumeContract> Get()
        {
            var resumes = _uow.ResumeRepository.GetAll();

            foreach (var resume in resumes)
            {
                var timeStamps = resume.TimeStamps.OrderByDescending(o => o.FromDate).ToList();
                resume.TimeStamps = timeStamps;
            }

            return resumes.ToContracts();
        }

        public ResumeContract Get(int id)
        {
            return _uow.ResumeRepository.Get(id).ToContract();
        }

        public void Post(ResumeContract resumeContract)
        {
            _uow.ResumeRepository.CreateOrUpdate(resumeContract.ToEntity());
        }

        public void Delete(int id)
        {
            _uow.ResumeRepository.Delete(id);
        }
    }
}
