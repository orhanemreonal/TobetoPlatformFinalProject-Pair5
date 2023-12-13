using Core.Entities;

namespace Entities.Concretes
{
    public class Experience : Entity<Guid>
    {
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public string Sector { get; set; }
        public City City { get; set; }
        public bool IsContinued { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? JobDescription { get; set; }
    }
}
