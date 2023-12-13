using Core.Entities;

namespace Entities.Concretes
{
    public class Course : Entity<Guid>
    {

        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public List<Class>? Classes { get; set; }


    }
}