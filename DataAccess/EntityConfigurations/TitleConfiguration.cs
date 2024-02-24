using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class TitleConfiguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.ToTable("Titles").HasKey(t => t.Id);
            builder.Property(t => t.Id).HasColumnName("Id").IsRequired();
            builder.Property(t => t.TopicId).HasColumnName("TopicId").IsRequired();
            //builder.Property(t => t.LikeId).HasColumnName("LikeId").IsRequired();
            builder.Property(t => t.Name).HasColumnName("Name").IsRequired();
            builder.Property(t => t.Description).HasColumnName("Description").IsRequired();
            builder.Property(t => t.Point).HasColumnName("Point").IsRequired();
            builder.Property(t => t.Subtype).HasColumnName("Subtype").IsRequired();
            builder.Property(t => t.VideoLanguage).HasColumnName("VideoLanguage").IsRequired();
            builder.Property(t => t.VideoLink).HasColumnName("VideoLink").IsRequired();
            builder.Property(t => t.VideoTime).HasColumnName("VideoTime").IsRequired();

            builder.HasOne(t => t.Topic).WithMany(top => top.Titles).HasForeignKey(t => t.TopicId);
            //builder.HasOne(t => t.Like).WithOne(l => l.Title).HasForeignKey<Title>(t => t.LikeId);


            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);


        }
    }
}
