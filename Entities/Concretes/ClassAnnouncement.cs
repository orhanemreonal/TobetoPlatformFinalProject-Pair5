using Core.Entities;

namespace Entities.Concretes
{
    public class ClassAnnouncement : Entity<Guid>
    {
        public Guid AnnouncementId { get; set; }
        public Guid ClassRoomId { get; set; }
        public ClassRoom? ClassRoom { get; set; }
        public Announcement? Announcement { get; set; }

    }
}
