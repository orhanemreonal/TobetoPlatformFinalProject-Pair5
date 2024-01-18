using Core.Entities;

namespace Entities.Concretes
{
    public class AsyncVideo : Entity<Guid>
    {
        public Guid LikeId { get; set; }
        public Guid TopicId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Like? Like { get; set; }
        public Topic? Topic { get; set; }
    }
}
