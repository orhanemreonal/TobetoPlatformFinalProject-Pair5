using Core.Entities;

namespace Entities.Concretes
{
    public class ClassAnnouncement : Entity<Guid>
    {
        public Guid AnnouncementId { get; set; }
        public Guid ClassroomId { get; set; }
        public Classroom? Classroom { get; set; }
        public Announcement? Announcement { get; set; }

    }
}
