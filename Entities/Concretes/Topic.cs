using Core.Entities;

namespace Entities.Concretes
{
    public class Topic : Entity<Guid>
    {
        public string Name { get; set; }
        public List<AsyncVideo>? AsyncVideos { get; set; }
        public List<VirtualClass>? VirtualClasses { get; set; }
        public List<CourseTopic>? CourseTopics { get; set; }

        public List<Title>? Titles { get; set; }
    }
}

