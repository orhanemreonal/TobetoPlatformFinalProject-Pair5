using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class OperationClaimConfiguration : IEntityTypeConfiguration<OperationClaim>
    {
        public void Configure(EntityTypeBuilder<OperationClaim> builder)
        {
            builder.ToTable("OperationClaims").HasKey(b => b.Id);

            builder.Property(b => b.Name).HasColumnName("Name").IsRequired();

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);




        }


    }
}
