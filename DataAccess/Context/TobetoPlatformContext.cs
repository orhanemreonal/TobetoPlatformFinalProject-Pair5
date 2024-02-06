using Core.Entities.Concrete;
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
        public DbSet<AsyncVideo> AsyncVideos { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Competence> Competences { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<PersonalInformation> PersonalInformations { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<SocialMediaStudent> SocialMediaStudents { get; set; }
        public DbSet<StudentLanguage> StudentLanguages { get; set; }
        public DbSet<LanguageLevel> LanguageLevels { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<VirtualClass> VirtualClasses { get; set; }

        public DbSet<OperationClaim> OperationClaims { get; set; }

        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

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

