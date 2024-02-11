using Core.Entities;

namespace Entities.Concretes
{
    public class Certificate : Entity<Guid>
    {
        public Guid StudentId { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public string FilePath { get; set; }
        public Student? Student { get; set; }

    }
}