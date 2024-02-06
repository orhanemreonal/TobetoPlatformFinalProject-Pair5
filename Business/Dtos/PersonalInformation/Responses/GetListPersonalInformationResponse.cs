using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.PersonelInformations.Responses
{
    public class GetListPersonalInformationResponse
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? About { get; set; }
        public string IdentityNo { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }


    }
}
