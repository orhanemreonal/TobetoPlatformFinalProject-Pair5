using Core.Entities;

namespace Entities.Concretes
{
    public class Application : Entity<Guid>
    {
        public string Destription { get; set; }
        public bool IsAccepted { get; set; }
    }
}