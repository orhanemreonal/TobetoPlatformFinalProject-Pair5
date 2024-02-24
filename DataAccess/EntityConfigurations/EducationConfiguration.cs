using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class EducationConfiguration : IEntityTypeConfiguration<Education>
    {
        public void Configure(EntityTypeBuilder<Education> builder)
        {
            builder.ToTable("Educations").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.StudentId).HasColumnName("StudentId").IsRequired();

            builder.Property(b => b.EducationalStatus).HasColumnName("EducationalStatus").IsRequired();
            builder.Property(b => b.University).HasColumnName("University").IsRequired();
            builder.Property(b => b.Department).HasColumnName("Department").IsRequired();
            builder.Property(b => b.StartYear).HasColumnName("StartYear").IsRequired();
            builder.Property(b => b.GraduationYear).HasColumnName("GraduationYear");
            builder.Property(b => b.IsContinued).HasColumnName("IsContinued").IsRequired();


            builder.HasOne(c => c.Student).WithMany(s => s.Educations).HasForeignKey(e => e.StudentId);
            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);


        }
    }
}


