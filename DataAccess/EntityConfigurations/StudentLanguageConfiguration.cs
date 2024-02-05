using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class StudentLanguageConfiguration : IEntityTypeConfiguration<StudentLanguage>
    {
        public void Configure(EntityTypeBuilder<StudentLanguage> builder)
        {
            builder.ToTable("StudentLanguages").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.StudentId).HasColumnName("StudentId").IsRequired();
            builder.Property(b => b.LanguageId).HasColumnName("LanguageId").IsRequired();
            builder.Property(b => b.LanguageLevelId).HasColumnName("LanguageLevelId").IsRequired();

            builder.HasOne(sl => sl.Student)
               .WithMany(s => s.StudentLanguages)
               .HasForeignKey(sl => sl.StudentId);
            builder.HasOne(sl => sl.Language)
               .WithMany(l => l.StudentLanguages)
               .HasForeignKey(sl => sl.LanguageId);
            builder.HasOne(sl => sl.LanguageLevel)
               .WithMany(l => l.StudentLanguages)
               .HasForeignKey(sl => sl.LanguageLevelId);


            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);

        }
    }
}
