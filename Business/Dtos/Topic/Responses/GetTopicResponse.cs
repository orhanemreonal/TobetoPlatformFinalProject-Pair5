using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Topic.Responses
{
    public class GetTopicResponse
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
