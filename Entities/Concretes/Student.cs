using Core.Entities;
using Core.Entities.Concrete;

namespace Entities.Concretes
{
    public class Student : Entity<Guid>
    {
        public Guid UserId { get; set; }
        public Guid? ClassroomId { get; set; }
        public Guid? PersonalInformationId { get; set; }
        public List<Experience>? Experiences { get; set; }
        public List<Education>? Educations { get; set; }
        public List<Competence>? Competences { get; set; }
        public List<StudentLanguage>? StudentLanguages { get; set; }
        public List<Certificate>? Certificates { get; set; }
        public List<SocialMediaStudent>? SocialMediaStudents { get; set; }
        public List<Survey>? Surveys { get; set; }
        public List<Exam>? Exams { get; set; }
        public List<Announcement>? Announcements { get; set; }
        public List<Application>? Applications { get; set; }
        public PersonalInformation? PersonalInformation { get; set; }
        public User? User { get; set; }
        public Classroom? Classroom { get; set; }
        public List<StudentLike>? StudentLikes { get; set; }

    }
}
