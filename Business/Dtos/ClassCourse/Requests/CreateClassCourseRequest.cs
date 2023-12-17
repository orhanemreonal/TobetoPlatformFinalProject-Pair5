using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.ClassCourse.Requests
{
    public class CreateClassCourseRequest
    {
        public Guid ClassId { get; set; }
        public Guid CourseId { get; set; }
    }
}
