using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class UserOperationClaimConfiguration : IEntityTypeConfiguration<UserOperationClaim>
    {
        public void Configure(EntityTypeBuilder<UserOperationClaim> builder)
        {

            builder.ToTable("UserOperationClaims").HasKey(b => b.Id);

            builder.Property(b => b.UserId).HasColumnName("UserId").IsRequired();
            builder.Property(b => b.OperationClaimId).HasColumnName("OperationClaimId").IsRequired();

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);




        }

    }
}
