using Core.Entities;

namespace Entities.Concretes
{
    public class StudentLike : Entity<Guid>
    {
        public Guid StudentId { get; set; }
        public Guid LikeId { get; set; }
        public Student? Student { get; set; }
        public Like? Like { get; set; }
    }
}
