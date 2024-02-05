using Core.Entities;

namespace Entities.Concretes
{
    public class StudentLanguage : Entity<Guid>
    {
        public Guid StudentId { get; set; }

        public Guid LanguageId { get; set; }

        public Guid LanguageLevelId { get; set; }

        public LanguageLevel? LanguageLevel { get; set; }

        public Student? Student { get; set; }

        public Language? Language { get; set; }
    }
}
