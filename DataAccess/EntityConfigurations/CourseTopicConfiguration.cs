using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class CourseTopicConfiguration : IEntityTypeConfiguration<CourseTopic>
    {
        public void Configure(EntityTypeBuilder<CourseTopic> builder)
        {
            builder.ToTable("CourseTopics").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.TopicId).HasColumnName("TopicId").IsRequired();
            builder.Property(b => b.CourseId).HasColumnName("CourseId").IsRequired();

            builder.HasOne(b => b.Topic)
                         .WithMany(c => c.CourseTopics)
                         .HasForeignKey(b => b.TopicId);


            builder.HasOne(b => b.Course)
                       .WithMany(c => c.CourseTopics)
                       .HasForeignKey(b => b.CourseId);

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
