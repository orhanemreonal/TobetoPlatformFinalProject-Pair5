using Core.Entities;

namespace Entities.Concretes
{
    public class PersonalInformation : Entity<Guid>
    {
        public Guid StudentId { get; set; }
        public string? About { get; set; }
        public string IdentityNo { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public Student? Student { get; set; }
    }
}
