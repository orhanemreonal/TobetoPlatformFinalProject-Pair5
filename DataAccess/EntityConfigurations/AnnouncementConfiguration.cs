using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class AnnouncementConfiguration : IEntityTypeConfiguration<Announcement>
    {
        public void Configure(EntityTypeBuilder<Announcement> builder)
        {
            builder.ToTable("Announcements").HasKey(a => a.Id);
            builder.Property(a => a.Type).HasColumnName("Type").IsRequired();
            builder.Property(a => a.Organization).HasColumnName("Organization").IsRequired();
            builder.Property(a => a.Title).HasColumnName("Title").IsRequired();
            builder.Property(a => a.Description).HasColumnName("Description").IsRequired();
            builder.Property(a => a.IsRead).HasColumnName("IsRead");
           


            builder.HasMany(a => a.ClassAnnouncements);

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
