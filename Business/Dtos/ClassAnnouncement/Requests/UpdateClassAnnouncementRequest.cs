using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.ClassAnnouncement.Requests
{
    public class UpdateClassAnnouncementRequest
    {
        public Guid Id { get; set; }
        public Guid AnnouncementId { get; set; }
        public Guid ClassId { get; set; }
    }
}
