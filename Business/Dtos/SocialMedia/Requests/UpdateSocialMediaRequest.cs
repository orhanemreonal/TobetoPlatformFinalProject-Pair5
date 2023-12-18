using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.SocialMedias.Requests
{
    public class UpdateSocialMediaRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

    }
}
