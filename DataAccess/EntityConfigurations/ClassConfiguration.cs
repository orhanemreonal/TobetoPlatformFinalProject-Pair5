using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class ClassConfiguration : IEntityTypeConfiguration<Class>
    {
        public void Configure(EntityTypeBuilder<Class> builder)
        {
            builder.ToTable("Classes").HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
            builder.Property(c => c.Name).HasColumnName("Name").IsRequired();
             builder.HasMany(c => c.Students);
            builder.HasMany(c => c.ClassCourses);
            builder.HasMany(a => a.ClassAnnouncements);


            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
