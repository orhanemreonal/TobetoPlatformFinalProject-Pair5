using Core.Entities;

namespace Entities.Concretes
{
    public class Competence : Entity<Guid>
    {
        public Guid StudentId { get; set; }
        public string Name { get; set; }
        public Student? Student { get; set; }
    }
}