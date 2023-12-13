using Core.Entities;

namespace Entities.Concretes
{
    public class ClassCourse : Entity<Guid>
    {
        public Guid ClassId { get; set; }
        public Guid CourseId { get; set; }
        public Class? Class { get; set; }
        public Course? Course { get; set; }
    }
}
