using Core.Entities;

namespace Entities.Concretes
{
    public class SocialMedia : Entity<Guid>
    {
        public Guid StudentId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public Student? Student { get; set; }

    }
}