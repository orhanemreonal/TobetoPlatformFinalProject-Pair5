using Core.Entities;

namespace Entities.Concretes
{
    public class CourseTopic : Entity<Guid>
    {
        public Guid TopicId { get; set; }
        public Guid CourseId { get; set; }
        public Topic? Topic { get; set; }
        public Course? Course { get; set; }
    }
}
