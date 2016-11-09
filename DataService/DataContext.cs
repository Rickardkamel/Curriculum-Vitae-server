using Models;
using System.Data.Entity;

namespace DataService
{
    public class DataContext : DbContext
    {
        public DataContext() : base("RickardKamel")
        {

        }

        public DbSet<About> About { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<TimeStamp> Timestamps { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Reference> References{ get; set; }
    }
}