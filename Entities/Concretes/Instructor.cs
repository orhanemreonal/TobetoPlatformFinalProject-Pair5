using Core.Entities;
using Core.Entities.Concrete;

namespace Entities.Concretes
{
    public class Instructor : Entity<Guid>
    {
        public Guid UserId { get; set; }
        public User? User { get; set; }

        //VirtualClass bağlantısı
    }
}
