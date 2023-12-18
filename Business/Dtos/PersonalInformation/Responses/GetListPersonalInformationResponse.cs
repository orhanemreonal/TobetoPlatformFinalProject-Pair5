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
        public string? About { get; set; }
        public string IdentityNo { get; set; }
        //public Country Country { get; set; }
        //public City City { get; set; }
        //public County County { get; set; }
        //public Neighbourhood Neighbourhood { get; set; }
        //public Street Street { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime BirthDate { get; set; }

    }
}
