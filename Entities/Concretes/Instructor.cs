using Core.Entities;

namespace Entities.Concretes
{
    public class Instructor : Entity<Guid>
    {
        public Guid UserId { get; set; }
        public User? User { get; set; }
    }
}
