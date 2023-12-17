using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.ClassAnnouncement.Responses
{
    public class GetListClassAnnouncementResponse
    {
        public Guid Id { get; set; }
        public Guid AnnouncementId { get; set; }
        public Guid ClassId { get; set; }
    }
}
