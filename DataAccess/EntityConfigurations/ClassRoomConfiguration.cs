using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class ClassRoomConfiguration : IEntityTypeConfiguration<ClassRoom>
    {
        public void Configure(EntityTypeBuilder<ClassRoom> builder)
        {
            builder.ToTable("ClassRooms").HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
            builder.Property(c => c.Name).HasColumnName("Name").IsRequired();
            builder.HasMany(c => c.Students);
            builder.HasMany(c => c.ClassCourses);
            builder.HasMany(a => a.ClassAnnouncements);


            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
