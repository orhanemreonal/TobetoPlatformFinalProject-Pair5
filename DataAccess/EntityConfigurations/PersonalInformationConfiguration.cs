using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class PersonalInformationConfiguration : IEntityTypeConfiguration<PersonalInformation>
    {
        public void Configure(EntityTypeBuilder<PersonalInformation> builder)
        {
            builder.ToTable("PersonalInformations").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.StudentId).HasColumnName("StudentId").IsRequired();
            builder.Property(b => b.About).HasColumnName("About");
            builder.Property(b => b.IdentityNo).HasColumnName("IdentityNo").IsRequired();
            builder.Property(b => b.Address).HasColumnName("Address").IsRequired();
            builder.Property(b => b.PhoneNumber).HasColumnName("PhoneNumber").IsRequired();
            builder.Property(b => b.BirthDate).HasColumnName("BirthDate").IsRequired();

            builder.HasOne(p => p.Student)
               .WithOne(s => s.PersonalInformation)
               .HasForeignKey<PersonalInformation>(p => p.StudentId);

            builder.HasIndex(indexExpression: b => b.IdentityNo, name: "UK_Languages_IdentityNo").IsUnique();

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
