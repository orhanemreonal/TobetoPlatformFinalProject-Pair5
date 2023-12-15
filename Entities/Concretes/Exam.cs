using Core.Entities;

namespace Entities.Concretes
{
    public class Exam : Entity<Guid>
    {
        public Guid StudentId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Student? Student { get; set; }
    }
}