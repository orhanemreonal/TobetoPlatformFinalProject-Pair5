using Entities.Concretes;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Students.Responses
{
    public class GetStudentLanguageResponse
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public Guid LanguageId { get; set; }

        public string LanguageLevel { get; set; }


    }
}
