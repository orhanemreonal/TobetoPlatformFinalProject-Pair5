using Entities;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace DataAccess.Context
{
    public class TobetoPlatformContext : DbContext
    {
        protected IConfiguration Configuration { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<ClassCourse> ClassCourses { get; set; }
        public DbSet<Competence> Competences { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<PersonalInformation> PersonalInformations { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<User> Users { get; set; }

        public TobetoPlatformContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
        {
            Configuration = configuration;
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}

