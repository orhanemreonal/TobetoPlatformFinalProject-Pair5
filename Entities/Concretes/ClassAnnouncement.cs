using Core.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class ClassAnnouncement : Entity<Guid>
    {
        public Guid AnnouncementId { get; set; }
        public Guid ClassId { get; set; }
        public Class? Class { get; set; }
        public Announcement? Announcement { get; set; }

    }
}
