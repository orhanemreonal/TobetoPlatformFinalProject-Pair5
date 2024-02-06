using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class ApplicationConfiguration : IEntityTypeConfiguration<Application>
    {
        public void Configure(EntityTypeBuilder<Application> builder)
        {
            builder.ToTable("Applications").HasKey(a => a.Id);
            builder.Property(a => a.Id).HasColumnName("Id").IsRequired();
            builder.Property(a => a.StudentId).HasColumnName("StudentId").IsRequired();
            builder.Property(a => a.Title).HasColumnName("Title").IsRequired();
            builder.Property(a => a.Description).HasColumnName("Description").IsRequired();
            builder.Property(a => a.IsAccepted).HasColumnName("IsAccepted");

            builder.HasOne(a => a.Student)
                    .WithMany(s => s.Applications)
                    .HasForeignKey(a => a.StudentId);


            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);




        }
    }
}
