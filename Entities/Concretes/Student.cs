using Core.Entities;

namespace Entities.Concretes
{
    public class Student : Entity<Guid>
    {
        public Guid UserId { get; set; }
        public string ClassName { get; set; }

        public List<Experience> Experiences { get; set; }
        public List<Education> Educations { get; set; }
        public List<Competence>? Competences { get; set; }
        public List<Language>? Languages { get; set; }
        public List<Certificate>? Certificates { get; set; }
        public List<SocialMedia>? SocialMedias { get; set; }
        public List<Survey> Surveys { get; set; }
        public List<Exam> Exams { get; set; }
        public List<Announcement> Announcements { get; set; }
        public List<Application> Applications { get; set; }
        public PersonalInformation PersonalInformation { get; set; }
    }
}
