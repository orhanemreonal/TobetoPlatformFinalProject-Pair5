using Core.Entities;

namespace Entities.Concretes
{
    public class SocialMediaStudent : Entity<Guid>
    {
        public Guid StudentId { get; set; }

        public Guid SocialMediaId { get; set; }
        public string Url { get; set; }

        public SocialMedia? SocialMedia { get; set; }

        public Student? Student { get; set; }


    }
}
