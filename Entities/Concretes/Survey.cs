using Core.Entities;

namespace Entities.Concretes
{
    public class Survey : Entity<Guid>
    {
        public Guid ClassRoomId { get; set; }
        public string Description { get; set; }
        public ClassRoom? ClassRoom { get; set; }
    }
}