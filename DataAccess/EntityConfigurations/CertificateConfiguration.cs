using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class CertificateConfiguration : IEntityTypeConfiguration<Certificate>
    {
        public void Configure(EntityTypeBuilder<Certificate> builder)
        {
            builder.ToTable("Certificates").HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
            builder.Property(c => c.StudentId).HasColumnName("StudentId").IsRequired();
            builder.Property(c => c.FileName).HasColumnName("FileName").IsRequired();
            builder.Property(c => c.FileExtension).HasColumnName("FileExtension").IsRequired();
            builder.Property(c => c.FilePath).HasColumnName("FilePath").IsRequired();

            builder.HasOne(c => c.Student)
                .WithMany(s => s.Certificates)
                .HasForeignKey(c => c.StudentId);

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
