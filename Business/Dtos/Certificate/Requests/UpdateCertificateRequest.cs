﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Certificate.Requests
{
    public class UpdateCertificateRequest
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }

        public string Name { get; set; }
        public byte[] Folder { get; set; }
    }
}
