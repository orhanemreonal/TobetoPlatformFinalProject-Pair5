using Core.Entities;

namespace Entities.Concretes
{
    public class Announcement : Entity<Guid>
    {
        public string Type { get; set; }
        public string Organization { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool? IsRead { get; set; }
        public List<ClassAnnouncement>? ClassAnnouncements { get;}

    }
}