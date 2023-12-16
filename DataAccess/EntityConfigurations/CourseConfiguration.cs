using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Courses").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b=>b.Name).HasColumnName("Name").IsRequired();
            builder.Property(b=>b.ImageUrl).HasColumnName("Image Url");
            builder.Property(b=>b.About).HasColumnName("About");
            builder.Property(b => b.StartDate).HasColumnName("Start Date").IsRequired();
            builder.Property(b => b.EndDate).HasColumnName("End Date").IsRequired();
            builder.Property(b => b.SpentTime).HasColumnName("Spent Time");
            builder.Property(b => b.EstimatedTime).HasColumnName("Estimated Time");

            builder.HasOne(c => c.Company).WithMany().HasForeignKey(c => c.CompanyId).IsRequired();

            builder.HasOne(c => c.Category).WithMany().HasForeignKey(c => c.CategoryId).IsRequired();

            builder.HasMany(c => c.Classes).WithOne().HasForeignKey(cl => cl.Id).OnDelete(DeleteBehavior.Cascade);

        }
    }
}
