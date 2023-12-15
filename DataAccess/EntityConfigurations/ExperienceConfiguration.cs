using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class ExperienceConfiguration : IEntityTypeConfiguration<Experience>
    {
        public void Configure(EntityTypeBuilder<Experience> builder)
        {
            builder.ToTable("Experience").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();

            builder.HasOne(c => c.Student).WithMany(s => s.Experiences).HasForeignKey(e => e.StudentId);
        }
    }
}
