using Core.Entities;

namespace Entities.Concretes
{
    public class Classroom : Entity<Guid>
    {
        public string Name { get; set; }
        public List<Student>? Students { get; set; }
        public List<ClassroomCourse>? ClassroomCourses { get; set; }
        public List<ClassAnnouncement>? ClassAnnouncements { get; set; }

        public List<Survey>? Surveys { get; set; }
    }
}