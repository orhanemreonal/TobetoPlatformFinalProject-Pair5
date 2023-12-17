using Core.Entities;

namespace Entities.Concretes
{
    public class ClassCourse : Entity<Guid>
    {
        public Guid ClassRoomId { get; set; }
        public Guid CourseId { get; set; }
        public ClassRoom? ClassRoom { get; set; }
        public Course? Course { get; set; }
    }
}
