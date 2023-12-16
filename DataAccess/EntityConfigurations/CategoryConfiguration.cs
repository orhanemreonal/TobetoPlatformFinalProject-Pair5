using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.Name).HasColumnName("Name").IsRequired();

            builder.HasMany(ct => ct.Courses)
               .WithOne(c => c.Category)
               .HasForeignKey(c => c.CategoryId);

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);


        }
    }
}
