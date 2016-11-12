using System.Collections.Generic;
using Models;

namespace DataService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataService.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataService.DataContext context)
        {
            var aboutMe = new About
            {
                Id = 1,
                Name = "Rickard Kamel",
                BirthDate = new DateTime(1992, 01, 27).Date,
                Adress = "Hagendalsvagen 20 A, 69230 Kumla, Sweden",
                Nationality = "Swedish",
                Phone = "+46 (0)707 762 303",
                Email = "Rickardkamel@gmail.com"
            };

            IList<TimeStamp> timeStampList = new List<TimeStamp>
            {
                new TimeStamp
                {
                    Id = 1,
                    Title = "Painters Degree",
                    SubTitle = "Tullangsskolan, Orebro, Sweden",
                    Text = "My first professional education. I chose this course because it was a high chance of getting a job after graduation.",
                    FromDate = new DateTime(2007, 08, 10),
                    ToDate = new DateTime(2010, 06, 10),
                    ResumeId = 1
                },
                new TimeStamp
                {
                    Id = 2,
                    Title = "Personal Trainer Certificate",
                    SubTitle = "Personal Trainer, DS Training School, Stockholm, Sweden",
                    Text = "I have always had a burning passion for training. After I have helped many with their training, I felt that I " +
                           "wanted to invest in myself and procure deeper knowledge of personal training and how the anatomy works.",
                    FromDate = new DateTime(2015, 03, 10),
                    ToDate = new DateTime(2015, 04, 10),
                    ResumeId = 1
                },
                new TimeStamp
                {
                    Id = 3,
                    Title = "Developer",
                    SubTitle = "Microsoft .NET developer, EC Education, Orebro, Sweden",
                    Text = "After 6 years of working as a painter, I felt that this was not something I wanted to do a bigger part of my life. " +
                           "I started to look for other professions that could suit me better and where I could make a career in. " +
                           "I then found this course and today am really happy with my choice of profession.",
                    FromDate = new DateTime(2015, 08, 11),
                    ToDate = new DateTime(2017, 05, 01),
                    ResumeId = 1
                },
                new TimeStamp
                {
                    Id = 4,
                    Title = "Painter",
                    SubTitle = "Orebro Maleri AB & Sanda Maleri AB",
                    Text = "I worked at two companies during this time. I was at Orebro Maleri for 5 years, " +
                           "and Sanda Maleri for 1 year, and worked with all aspects of the profession.",
                    FromDate = new DateTime(2010, 06, 10),
                    ToDate = new DateTime(2015, 01, 21),
                    ResumeId = 2
                },
                new TimeStamp
                {
                    Id = 5,
                    Title = "Developer",
                    SubTitle = "IT-Mastaren, Orebro, Sweden",
                    Text = "What began with a weekly internship led to a full internship from the start of April to the end of June, " +
                           "which then resulted in a summer job and employment during studies.",
                    FromDate = new DateTime(2016, 01, 10),
                    ToDate = new DateTime(2017, 01, 01),
                    ResumeId = 2
                }
            };

            var resumeList = new List<Resume>
            {
                new Resume { Id = 1, Section = "Education", TimeStamps =  timeStampList.Where(x => x.ResumeId == 1).ToList()},
                new Resume { Id = 2, Section = "Experience", TimeStamps = timeStampList.Where(x => x.ResumeId == 2).ToList()},
            };

            var skills = new List<Skill>
            {
                new Skill {Id = 1, Name = "C#", Percentage = 85},
                new Skill {Id = 11, Name = "Entity Framework", Percentage = 84},
                new Skill {Id = 7, Name = "Angular2", Percentage = 77},
                new Skill {Id = 10, Name = "HTML & CSS", Percentage = 75},
                new Skill {Id = 3, Name = "Web Api", Percentage = 72},
                new Skill {Id = 5, Name = "JavaScript", Percentage = 70},
                new Skill {Id = 9, Name = "Ionic", Percentage = 68},
                new Skill {Id = 4, Name = "TypeScript", Percentage = 66},
                new Skill {Id = 8, Name = "SQL", Percentage = 65},
                new Skill {Id = 6, Name = "AngularJS", Percentage = 63},
                new Skill {Id = 2, Name = "MVC", Percentage = 58},
                new Skill {Id = 12, Name = "Azure", Percentage = 45},
                new Skill {Id = 13, Name = "Active Directory", Percentage = 35},
                new Skill {Id = 14, Name = "Electron", Percentage = 30},
            };

            var projects = new List<Project>
            {
                new Project
                {
                    Id = 1,
                    Title = "Document Management",
                    GitLink = "https://github.com/Rickardkamel/DocumentHandler-client",
                    Text = "Web application for a customer during my employement at IT-Mastaren. " +
                           "The plan was to digitize their document creation and give them an easy way to manage their documents. "
                },
                new Project
                {
                    Id = 2,
                    Title = "Employee App",
                    GitLink = "https://github.com/Rickardkamel/Ionic-App",
                    Text = "The company I did my internship at needed an application where they could report their absence, " +
                           "see news from the company intranet and manage their account.The key here was to build the application as " +
                           "dynamic as possible to later add more functionality. "
                }
            };


            var references = new List<Reference>
            {
                new Reference
                {
                    Id = 1,
                    Company = "Ovo Energy",
                    Name = "Marcus Carlsson",
                    ImageUrl = "marcus.jpg",
                    Occupation = "Fullstack Developer",
                    QuoteText = "Rickard is one of the most hungry junior developers I have ever met. He is an absolute must-have for companies looking for a key player who can be shaped to fit any role the company needs, but also to learn from."
                },
                new Reference
                {
                    Id = 2,
                    Company = "IT-Mastaren",
                    Name = "Anders Persson",
                    ImageUrl = "anders.jpg",
                    Occupation = "Team Director",
                    QuoteText = "Rickard, a committed and focused person, has great drive and exceptional will to develop."
                },
                new Reference
                {
                    Id = 3,
                    Company = "IT-Mastaren",
                    Name = "Michel Ishak",
                    ImageUrl = "michel.jpg",
                    Occupation = "Developer",
                    QuoteText = "Working with Rickard is a delight, he takes responsibility, documents and above all makes sure that things gets done. " +
                                "He is comfortable in different situations, both socially and in programming, easy to learn and takes criticism to become better. " +
                                "Nice guy who spread laughter and his good humor to his surroundings"
                },
                new Reference
                {
                    Id = 4,
                    Company = "EC Utbildning",
                    Name = "Jonas Enander",
                    ImageUrl = "jonas.jpg",
                    Occupation = "School Director",
                    QuoteText = "For a referral, please contact: +46 (0)19 764 14 53"
                }
            };

            references.ForEach(x => context.References.Add(x));
            projects.ForEach(x => context.Projects.Add(x));
            skills.ForEach(x => context.Skills.Add(x));
            resumeList.ForEach(x => context.Resumes.Add(x));
            context.About.Add(aboutMe);
        }
    }
}
