using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class LikeConfiguration : IEntityTypeConfiguration<Like>
    {
        public void Configure(EntityTypeBuilder<Like> builder)
        {
            builder.ToTable("Likes").HasKey(a => a.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.CourseId).HasColumnName("CourseId").IsRequired();
            builder.Property(b => b.TitleId).HasColumnName("TitleId").IsRequired();

            builder.HasOne(l => l.Course)
               .WithOne(c => c.Like)
            .HasForeignKey<Like>(l => l.CourseId);
            //.HasForeignKey<Course>(c => c.LikeId);

            builder.HasOne(l => l.Title)
                .WithOne(t => t.Like)
                .HasForeignKey<Like>(l => l.TitleId);

            builder.HasMany(l => l.StudentLikes).WithOne(s => s.Like).HasForeignKey(s => s.LikeId);

            builder.HasMany(l => l.AsyncVideos).WithOne(a => a.Like).HasForeignKey(a => a.LikeId);

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
