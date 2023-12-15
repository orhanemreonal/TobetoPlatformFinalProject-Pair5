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

        }
    }
}
