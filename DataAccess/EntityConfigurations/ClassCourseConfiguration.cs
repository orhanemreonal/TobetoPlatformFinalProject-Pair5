using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class ClassCourseConfiguration : IEntityTypeConfiguration<ClassCourse>
    {
        public void Configure(EntityTypeBuilder<ClassCourse> builder)
        {
            builder.ToTable("ClassCourses").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.CourseId).HasColumnName("CourseId").IsRequired();
            builder.Property(b => b.ClassroomId).HasColumnName("ClassId").IsRequired();

            builder.HasOne(b => b.Classroom)
                     .WithMany(c => c.ClassCourses)
                     .HasForeignKey(b => b.ClassroomId);


            builder.HasOne(b => b.Course)
                   .WithMany(c => c.ClassCourses)
                   .HasForeignKey(b => b.CourseId);

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
