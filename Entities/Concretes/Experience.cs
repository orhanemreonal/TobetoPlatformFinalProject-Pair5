using Core.Entities;

namespace Entities.Concretes
{
    public class Experience : Entity<Guid>
    {
        public Guid StudentId { get; set; }
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public string Sector { get; set; }
        public string City { get; set; }
        public bool IsContinued { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? JobDescription { get; set; }
        public Student? Student { get; set; }
    }
}
