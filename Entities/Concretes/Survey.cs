using Core.Entities;

namespace Entities.Concretes
{
    public class Survey : Entity<Guid>
    {
        public Guid ClassroomId { get; set; }
        public string Description { get; set; }
        public Classroom? Classroom { get; set; }
    }
}