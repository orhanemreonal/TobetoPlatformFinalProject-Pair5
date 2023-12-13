using Core.Entities;

namespace Entities.Concretes
{
    public class Survey : Entity<Guid>
    {
        public Guid ClassId { get; set; }
        public string Description { get; set; }
        public Class? Class { get; set; }
    }
}