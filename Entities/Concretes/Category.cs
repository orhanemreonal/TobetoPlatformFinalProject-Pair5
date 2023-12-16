using Core.Entities;

namespace Entities.Concretes
{
    public class Category : Entity<Guid>
    {
        public string Name { get; set; }

        public List<Course>? Courses { get; set; }
    }
}
