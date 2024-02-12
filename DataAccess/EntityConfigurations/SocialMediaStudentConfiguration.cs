using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class SocialMediaStudentConfiguration : IEntityTypeConfiguration<SocialMediaStudent>
    {
        public void Configure(EntityTypeBuilder<SocialMediaStudent> builder)
        {

            builder.ToTable("SocialMediaStudents").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.SocialMediaId).HasColumnName("SocialMediaId").IsRequired();
            builder.Property(b => b.StudentId).HasColumnName("StudentId");
            builder.Property(b => b.Url).HasColumnName("Url");

            builder.HasOne(sl => sl.Student)
              .WithMany(s => s.SocialMediaStudents)
              .HasForeignKey(sl => sl.StudentId);
            builder.HasOne(sl => sl.SocialMedia)
               .WithMany(l => l.SocialMediaStudents)
               .HasForeignKey(sl => sl.SocialMediaId);
            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
