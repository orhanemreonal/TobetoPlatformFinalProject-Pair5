using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class AsyncVideoConfiguration : IEntityTypeConfiguration<AsyncVideo>
    {
        public void Configure(EntityTypeBuilder<AsyncVideo> builder)
        {
            builder.ToTable("AsyncVideos").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.LikeId).HasColumnName("LikeId").IsRequired();
            builder.Property(b => b.TopicId).HasColumnName("TopicId").IsRequired();
            builder.Property(a => a.Name).HasColumnName("Name").IsRequired();
            builder.Property(a => a.Description).HasColumnName("Description").IsRequired();

            builder.HasOne(b => b.Like)
                     .WithMany(c => c.AsyncVideos)
                     .HasForeignKey(b => b.LikeId);


            builder.HasOne(b => b.Topic)
                   .WithMany(c => c.AsyncVideos)
                   .HasForeignKey(b => b.TopicId);

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);




        }
    }
}
