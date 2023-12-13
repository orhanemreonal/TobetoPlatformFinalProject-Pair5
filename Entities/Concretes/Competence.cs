using Core.Entities;

namespace Entities.Concretes
{
    public class Competence : Entity<Guid>
    {
        public string Name { get; set; }
    }
}