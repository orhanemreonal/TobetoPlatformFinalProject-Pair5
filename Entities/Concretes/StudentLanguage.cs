using Core.Entities;

namespace Entities.Concretes
{
    public class StudentLanguage : Entity<Guid>
    {
        public Guid StudentId { get; set; }

        public Guid LanguageId { get; set; }

        public string LanguageLevel { get; set; }

        public Student? Student { get; set; }

        public Language? Language { get; set; }
    }
}
