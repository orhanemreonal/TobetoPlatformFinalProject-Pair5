using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Certificate.Requests
{
    public class CreateCertificateRequest
    {
        public Guid StudentId { get; set; }

        public string Name { get; set; }
        public byte[] Folder { get; set; }
    }
}
