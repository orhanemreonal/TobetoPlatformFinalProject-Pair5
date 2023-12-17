using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class ClassAnnouncementConfiguration : IEntityTypeConfiguration<ClassAnnouncement>
    {
        public void Configure(EntityTypeBuilder<ClassAnnouncement> builder)
        {
            builder.ToTable("ClassAnnouncements").HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
            builder.Property(c => c.AnnouncementId).HasColumnName("AnnouncementId").IsRequired();
            builder.Property(c => c.ClassRoomId).HasColumnName("ClassRoomId").IsRequired();

            builder.HasOne(b => b.ClassRoom)
                     .WithMany(c => c.ClassAnnouncements)
                     .HasForeignKey(b => b.ClassRoomId);

            builder.HasOne(c => c.Announcement)
                .WithMany(s => s.ClassAnnouncements)
                .HasForeignKey(c => c.AnnouncementId);

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
