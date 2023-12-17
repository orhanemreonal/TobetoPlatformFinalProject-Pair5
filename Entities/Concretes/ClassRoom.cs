using Core.Entities;

namespace Entities.Concretes
{
    public class ClassRoom : Entity<Guid>
    {
        public string Name { get; set; }
        public List<Student>? Students { get; set; }
        public List<ClassCourse>? ClassCourses { get; set; }
        public List<ClassAnnouncement>? ClassAnnouncements { get; set; }
    }
}