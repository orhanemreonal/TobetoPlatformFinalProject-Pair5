using Core.Entities;

namespace Entities.Concretes
{
    public class Class : Entity<Guid>
    {

        public string Name { get; set; }
        public List<Student>? Students { get; set; }
        public List<ClassCourse>? ClassCourses { get; set; } //sonradan eklendi - Nergis

    }
}