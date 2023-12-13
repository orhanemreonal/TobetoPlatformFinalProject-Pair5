using Core.Entities;

namespace Entities.Concretes
{
    public class Certificate : Entity<Guid>
    {
        public string Name { get; set; }
        public byte[] Folder { get; set; }

    }
}