using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class SurveyConfiguration : IEntityTypeConfiguration<Survey>
    {
        public void Configure(EntityTypeBuilder<Survey> builder)
        {
            builder.ToTable("Surveys").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.Description).HasColumnName("Description");
            builder.Property(s => s.ClassroomId).HasColumnName("ClassroomId").IsRequired();

            builder.HasOne(s => s.Classroom)
                .WithMany(c => c.Surveys).HasForeignKey(s => s.ClassroomId);
        }
    }
}