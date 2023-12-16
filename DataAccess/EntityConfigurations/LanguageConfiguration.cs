using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {

            builder.ToTable("Languages").HasKey(b => b.Id);

            builder.Property(b => b.Name).HasColumnName("Name").IsRequired();

            // builder.HasIndex(indexExpression: b => b.Name, name: "UK_Languages_Name").IsUnique();

            builder.HasMany(i => i.StudentLanguages).WithOne(u => u.Language).HasForeignKey(i => i.LanguageId);

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);




        }
    }


}
