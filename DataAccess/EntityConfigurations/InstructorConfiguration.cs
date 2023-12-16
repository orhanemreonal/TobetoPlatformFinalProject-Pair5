using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.ToTable("Instructors").HasKey(i => i.Id);
            builder.Property(i => i.Id).HasColumnName("Id").IsRequired();
            builder.Property(i => i.UserId).HasColumnName("UserId").IsRequired();

            builder.HasOne(i => i.User).WithMany(u => u.Instructors).HasForeignKey(i => i.UserId);  // 1-1 ilişki

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
