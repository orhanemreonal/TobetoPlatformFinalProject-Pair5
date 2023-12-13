using Core.Entities;

namespace Entities.Concretes
{
    public class Exam : Entity<Guid>
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}