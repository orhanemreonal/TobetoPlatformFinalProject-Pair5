using Core.Entities;

namespace Entities.Concretes
{
    public class Certificate : Entity<Guid>
    {
        public Guid StudentId { get; set; }
        public string Name { get; set; }
        public byte[] Folder { get; set; }
        public Student? Student { get; set; }

    }
}