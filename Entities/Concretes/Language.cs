using Core.Entities;
using Entities.Concretes;

namespace Entities
{
    public class Language : Entity<Guid>
    {
        public string Name { get; set; }
        public List<StudentLanguage>? StudentLanguages { get; set; }

    }
}