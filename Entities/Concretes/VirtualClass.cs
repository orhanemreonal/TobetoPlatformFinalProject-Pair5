using Core.Entities;

namespace Entities.Concretes
{
    public class VirtualClass : Entity<Guid>
    {
        public Guid TopicId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
        public string Name { get; set; }
        public string RecordLink { get; set; }
        //public List<string> VirtualClassLink { get; set; }
        public Topic? Topic { get; set; }
        public List<Instructor>? Instructors { get; set; }

    }
}
