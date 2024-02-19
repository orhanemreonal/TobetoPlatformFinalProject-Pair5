using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class ExperienceConfiguration : IEntityTypeConfiguration<Experience>
    {
        public void Configure(EntityTypeBuilder<Experience> builder)
        {
           
            

            builder.ToTable("Experiences").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.StudentId).HasColumnName("StudentId").IsRequired();
            builder.Property(b => b.CompanyName).HasColumnName("CompanyName").IsRequired();
            builder.Property(b => b.City).HasColumnName("City").IsRequired();
            builder.Property(b => b.Position).HasColumnName("Position").IsRequired();
            builder.Property(b => b.Sector).HasColumnName("Sector").IsRequired();
            builder.Property(b => b.IsContinued).HasColumnName("IsContinued").IsRequired();
            builder.Property(b => b.StartDate).HasColumnName("StartDate").IsRequired();
            builder.Property(b => b.EndDate).HasColumnName("EndDate");
            builder.Property(b => b.JobDescription).HasColumnName("JobDescription");
           

            builder.HasOne(c => c.Student).WithMany(s => s.Experiences).HasForeignKey(e => e.StudentId);

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);

        }
    }
}
