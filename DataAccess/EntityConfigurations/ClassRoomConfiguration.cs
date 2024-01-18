using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class ClassroomConfiguration : IEntityTypeConfiguration<Classroom>
    {
        public void Configure(EntityTypeBuilder<Classroom> builder)
        {
            builder.ToTable("Classrooms").HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
            builder.Property(c => c.Name).HasColumnName("Name").IsRequired();
            builder.HasMany(c => c.Students);
            builder.HasMany(c => c.ClassroomCourses);
            builder.HasMany(a => a.ClassAnnouncements);


            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
