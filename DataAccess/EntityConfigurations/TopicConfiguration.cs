using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class TopicConfiguration : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            builder.ToTable("Topics").HasKey(t => t.Id);
            builder.Property(t => t.Id).HasColumnName("Id").IsRequired();
            builder.Property(t => t.Name).HasColumnName("Name").IsRequired();

            builder.HasMany(t => t.AsyncVideos).WithOne(av => av.Topic).HasForeignKey(av => av.TopicId);
            builder.HasMany(t => t.VirtualClasses).WithOne(v => v.Topic).HasForeignKey(v => v.TopicId);
            builder.HasMany(t => t.CourseTopics).WithOne(c => c.Topic).HasForeignKey(c => c.TopicId);
            builder.HasMany(t => t.Titles).WithOne(t => t.Topic).HasForeignKey(t => t.TopicId); ;
            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);


        }
    }
}
