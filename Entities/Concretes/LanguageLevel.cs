using Core.Entities;

namespace Entities.Concretes
{
    public class LanguageLevel : Entity<Guid>
    {
        public string Level { get; set; }
        public List<StudentLanguage>? StudentLanguages { get; set; }
    }
}
