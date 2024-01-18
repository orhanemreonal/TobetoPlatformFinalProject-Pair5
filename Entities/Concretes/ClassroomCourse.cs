using Core.Entities;

namespace Entities.Concretes
{
    public class ClassroomCourse : Entity<Guid>
    {
        public Guid ClassroomId { get; set; }
        public Guid CourseId { get; set; }
        public Classroom? Classroom { get; set; }
        public Course? Course { get; set; }
    }
}
