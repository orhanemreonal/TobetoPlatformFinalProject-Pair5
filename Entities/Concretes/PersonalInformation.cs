using Core.Entities;

namespace Entities.Concretes
{
    public class PersonalInformation : Entity<Guid>
    {
        public Guid StudentId { get; set; }
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

        public Student? Student { get; set; }
    }
}
