using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Instructor.Requests
{
    public class UpdateInstructorRequest
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
    }
}
