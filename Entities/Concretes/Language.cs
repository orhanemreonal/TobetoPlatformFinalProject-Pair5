using Core.Entities;
using Entities.Concretes;

namespace Entities
{
    public class Language : Entity<Guid>
    {
        public Guid StudentId { get; set; }
        public string Name { get; set; }
        public Student? Student { get; set; }
    }
}