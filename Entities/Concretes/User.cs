using Core.Entities;

namespace Entities.Concretes
{
    public class User : Entity<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
        public DateTime? BirthDate { get; set; }
        public List<Course>? Courses { get; set; }
        List<Student>? Students { get; set; }
        List<Instructor>? Instructors { get; set; }

    }
}
