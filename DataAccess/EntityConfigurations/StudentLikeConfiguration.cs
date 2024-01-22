using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class StudentLikeConfiguration : IEntityTypeConfiguration<StudentLike>
    {
        public void Configure(EntityTypeBuilder<StudentLike> builder)
        {
            builder.ToTable("StudentLikes").HasKey(a => a.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.StudentId).HasColumnName("StudentId").IsRequired();
            builder.Property(b => b.LikeId).HasColumnName("LikeId").IsRequired();

            builder.HasOne(sl => sl.Student)
               .WithMany(s => s.StudentLikes)
               .HasForeignKey(sl => sl.StudentId);

            builder.HasOne(sl => sl.Like)
               .WithMany(l => l.StudentLikes)
               .HasForeignKey(sl => sl.LikeId);


            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}