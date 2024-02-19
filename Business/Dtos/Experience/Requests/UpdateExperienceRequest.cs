using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Experience.Requests
{
    public class UpdateExperienceRequest
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public string City { get; set; }
        public string Sector { get; set; }
        public bool IsContinued { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? JobDescription { get; set; }
        
    }
}
