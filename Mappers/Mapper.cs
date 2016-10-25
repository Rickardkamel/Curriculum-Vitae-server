using Models;
using System.Collections.Generic;
using System.Linq;
using Contracts;

namespace Mappers
{
    public static class Mapper
    {
        #region Contract

        #region Object

        public static SkillContract ToContract(this Skill skill)
        {
            return new SkillContract
            {
                Id = skill.Id,
                Name = skill.Name,
                Percentage = skill.Percentage
            };
        }

        public static AboutContract ToContract(this About about)
        {
            return new AboutContract
            {
                Id = about.Id,
                Name = about.Name,
                Email = about.Email,
                Phone = about.Phone,
                Adress = about.Adress,
                BirthDate = about.BirthDate,
                Nationality = about.Nationality,
            };
        }

        public static ProjectContract ToContract(this Project project)
        {
            return new ProjectContract
            {
                Id = project.Id,
                Text = project.Text,
                Title = project.Title
            };
        }

        public static ResumeContract ToContract(this Resume resume)
        {
            return new ResumeContract
            {
                Id = resume.Id,
                Section = resume.Section,
                TimeStamps = resume.TimeStamps.ToList().ToContracts()
            };
        }

        public static TimeStampContract ToContract(this TimeStamp timeStamp)
        {
            return new TimeStampContract
            {
                Id = timeStamp.Id,
                Date = timeStamp.Date,
                Text = timeStamp.Text,
                Title = timeStamp.Title,
                ResumeId = timeStamp.ResumeId,
                SubTitle = timeStamp.SubTitle,
            };
        }
        #endregion

        #region List

        public static List<SkillContract> ToContracts(this List<Skill> skills)
        {
            return skills.ConvertAll(x => new SkillContract
            {
                Id = x.Id,
                Name = x.Name,
                Percentage = x.Percentage
            });
        }

        public static List<AboutContract> ToContracts(this List<About> abouts)
        {
            return abouts.ConvertAll(x => new AboutContract
            {
                Id = x.Id,
                Name = x.Name,
                Phone = x.Phone,
                Email = x.Email,
                Adress = x.Adress,
                BirthDate = x.BirthDate,
                Nationality = x.Nationality,

            });
        }

        public static List<ProjectContract> ToContracts(this List<Project> projects)
        {
            return projects.ConvertAll(x => new ProjectContract
            {
                Id = x.Id,
                Text = x.Text,
                Title = x.Title
            });
        }

        public static List<ResumeContract> ToContracts(this List<Resume> resumes)
        {
            return resumes.ConvertAll(x => new ResumeContract
            {
                Id = x.Id,
                Section = x.Section,
                TimeStamps = x.TimeStamps.ToList().ToContracts()
            });
        }

        public static List<TimeStampContract> ToContracts(this List<TimeStamp> timeStamps)
        {
            return timeStamps.ConvertAll(x => new TimeStampContract
            {
                Id = x.Id,
                Date = x.Date,
                Text = x.Text,
                Title = x.Title,
                ResumeId = x.ResumeId,
                SubTitle = x.SubTitle,

            });
        }


        #endregion

        #endregion

        #region Entity (Database)

        #region Object

        public static Skill ToEntity(this SkillContract skillContract)
        {
            return new Skill
            {
                Id = skillContract.Id,
                Name = skillContract.Name,
                Percentage = skillContract.Percentage
            };
        }

        public static About ToEntity(this AboutContract aboutContract)
        {
            return new About
            {
                Id = aboutContract.Id,
                Name = aboutContract.Name,
                Email = aboutContract.Email,
                Phone = aboutContract.Phone,
                Adress = aboutContract.Adress,
                BirthDate = aboutContract.BirthDate,
                Nationality = aboutContract.Nationality,
            };
        }

        public static Project ToEntity(this ProjectContract projectContract)
        {
            return new Project
            {
                Id = projectContract.Id,
                Text = projectContract.Text,
                Title = projectContract.Title
            };
        }

        public static Resume ToEntity(this ResumeContract resumeContract)
        {
            return new Resume
            {
                Id = resumeContract.Id,
                Section = resumeContract.Section,
                TimeStamps = resumeContract.TimeStamps.ToList().ToEntities()
            };
        }

        public static TimeStamp ToEntity(this TimeStampContract timeStampContract)
        {
            return new TimeStamp
            {
                Id = timeStampContract.Id,
                Date = timeStampContract.Date,
                Text = timeStampContract.Text,
                Title = timeStampContract.Title,
                ResumeId = timeStampContract.ResumeId,
                SubTitle = timeStampContract.SubTitle,
            };
        }

        #endregion

        #region List

        public static List<Skill> ToEntities(this List<SkillContract> skillContracts)
        {
            return skillContracts.ConvertAll(x => new Skill
            {
                Id = x.Id,
                Name = x.Name,
                Percentage = x.Percentage
            });
        }

        public static List<About> ToEntities(this List<AboutContract> aboutContracts)
        {
            return aboutContracts.ConvertAll(x => new About
            {
                Id = x.Id,
                Name = x.Name,
                Phone = x.Phone,
                Email = x.Email,
                Adress = x.Adress,
                BirthDate = x.BirthDate,
                Nationality = x.Nationality,

            });
        }

        public static List<Project> ToEntities(this List<ProjectContract> projectContracts)
        {
            return projectContracts.ConvertAll(x => new Project
            {
                Id = x.Id,
                Text = x.Text,
                Title = x.Title
            });
        }

        public static List<Resume> ToEntities(this List<ResumeContract> resumeContracts)
        {
            return resumeContracts.ConvertAll(x => new Resume
            {
                Id = x.Id,
                Section = x.Section,
                TimeStamps = x.TimeStamps.ToList().ToEntities()
            });
        }

        public static List<TimeStamp> ToEntities(this List<TimeStampContract> timeStampContracts)
        {
            return timeStampContracts.ConvertAll(x => new TimeStamp
            {
                Id = x.Id,
                Date = x.Date,
                Text = x.Text,
                Title = x.Title,
                ResumeId = x.ResumeId,
                SubTitle = x.SubTitle,

            });
        }


        #endregion

        #endregion
    }
}
