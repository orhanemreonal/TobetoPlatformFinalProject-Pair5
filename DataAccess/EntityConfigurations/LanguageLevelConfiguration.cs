using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class LanguageLevelConfiguration : IEntityTypeConfiguration<LanguageLevel>
    {
        public void Configure(EntityTypeBuilder<LanguageLevel> builder)
        {

            builder.ToTable("LanguageLevels").HasKey(b => b.Id);

            builder.Property(b => b.Level).HasColumnName("Level").IsRequired();

            builder.HasMany(i => i.StudentLanguages).WithOne(u => u.LanguageLevel).HasForeignKey(i => i.LanguageLevelId);

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);


        }


    }
}
