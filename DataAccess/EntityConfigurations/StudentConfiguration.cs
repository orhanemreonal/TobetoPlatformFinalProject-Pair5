using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students").HasKey(s => s.Id);
            builder.Property(s => s.UserId).HasColumnName("UserId").IsRequired();
            builder.Property(s => s.ClassRoomId).HasColumnName("ClassRoomId").IsRequired();
            builder.Property(s => s.PersonalInformationId).HasColumnName("PersonalInformationId").IsRequired();
            builder.HasMany(s => s.Experiences);
            builder.HasMany(s => s.Educations);
            builder.HasMany(s => s.Competences);
            builder.HasMany(s => s.StudentLanguages);
            builder.HasMany(s => s.Certificates);
            builder.HasMany(s => s.SocialMedias);
            builder.HasMany(s => s.Surveys);
            builder.HasMany(s => s.Exams);
            builder.HasMany(s => s.Announcements);
            builder.HasMany(s => s.Applications);

            builder.HasOne(s => s.PersonalInformation);

            builder.HasOne(s => s.User).WithMany(u => u.Students).HasForeignKey(s => s.UserId);

            builder.HasOne(s => s.ClassRoom)
                .WithMany(u => u.Students)
                .HasForeignKey(s => s.ClassRoomId);



        }
    }
}
