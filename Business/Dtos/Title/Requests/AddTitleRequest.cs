using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Title.Requests
{
    public class CreateTitleRequest
    {
        public Guid TopicId { get; set; }
        public Guid LikeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Point { get; set; }
        public string Subtype { get; set; }
        public string VideoLanguage { get; set; }
        public string VideoLink { get; set; }
    }
}
