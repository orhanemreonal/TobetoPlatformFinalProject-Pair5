using Core.Entities;

namespace Entities.Concretes
{
    public class SocialMedia : Entity<Guid>
    {

        public string Name { get; set; }
        public List<SocialMediaStudent>? SocialMediaStudents { get; set; }

    }
}