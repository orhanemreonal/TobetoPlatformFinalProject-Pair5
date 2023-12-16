using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class CompetenceConfiguration : IEntityTypeConfiguration<Competence>
    {
        public void Configure(EntityTypeBuilder<Competence> builder)
        {
            builder.ToTable("Competences").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.StudentId).HasColumnName("StudentId").IsRequired();
            builder.Property(b => b.Name).HasColumnName("Name").IsRequired();


            builder.HasOne(c => c.Student)
                .WithMany(s => s.Competences)
                .HasForeignKey(c => c.StudentId);

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
