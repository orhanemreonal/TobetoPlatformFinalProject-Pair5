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
            builder.Property(b => b.CategoryId).HasColumnName("CategoryId").IsRequired();
            builder.Property(b => b.CompanyId).HasColumnName("CompanyId").IsRequired();
            builder.Property(b => b.LikeId).HasColumnName("LikeId").IsRequired();
            builder.Property(b => b.Name).HasColumnName("Name").IsRequired();
            builder.Property(b => b.ImageUrl).HasColumnName("ImageUrl");
            builder.Property(b => b.About).HasColumnName("About");
            builder.Property(b => b.StartDate).HasColumnName("StartDate").IsRequired();
            builder.Property(b => b.EndDate).HasColumnName("EndDate").IsRequired();
            builder.Property(b => b.SpentTime).HasColumnName("SpentTime");
            builder.Property(b => b.EstimatedTime).HasColumnName("EstimatedTime");

            builder.HasOne(c => c.Company)
                .WithMany(cm => cm.Courses)
                .HasForeignKey(c => c.CompanyId);

            builder.HasOne(c => c.Category)
                .WithMany(ct => ct.Courses)
                .HasForeignKey(c => c.CategoryId);

            builder.HasOne(c => c.Like)
                .WithOne(ct => ct.Course)
                .HasForeignKey<Course>(c => c.LikeId);

            builder.HasMany(c => c.ClassroomCourses);

            builder.HasMany(c => c.CourseTopics);


            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}