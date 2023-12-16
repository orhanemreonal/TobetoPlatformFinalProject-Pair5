using Core.Entities;

namespace Entities.Concretes
{
    public class Course : Entity<Guid>
    {
        public Guid CategoryId { get; set; }

        public Guid CompanyId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }

        public string About { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime SpentTime { get; set; }
        public DateTime EstimatedTime { get; set; }
        public Company? Company { get; set; }
        public Category? Category { get; set; }
        public List<ClassCourse>? ClassCourses { get; set; } //sonradan eklendi - Nergis


    }


}