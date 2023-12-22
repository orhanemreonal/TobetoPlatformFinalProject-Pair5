using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class UserOperationClaimConfiguration : IEntityTypeConfiguration<UserOperationClaim>
    {
        public void Configure(EntityTypeBuilder<UserOperationClaim> builder)
        {


            builder.ToTable("UserOperationClaims").HasKey(uoc => uoc.Id);

            builder.Property(uoc => uoc.Id).HasColumnName("Id").IsRequired();
            builder.Property(uoc => uoc.UserId).HasColumnName("UserId").IsRequired();
            builder.Property(uoc => uoc.OperationClaimId).HasColumnName("OperationClaimId").IsRequired();
            builder.Property(uoc => uoc.CreatedDate).HasColumnName("CreatedDate").IsRequired();
            builder.Property(uoc => uoc.UpdatedDate).HasColumnName("UpdatedDate");
            builder.Property(uoc => uoc.DeletedDate).HasColumnName("DeletedDate");

            builder.HasQueryFilter(uoc => !uoc.DeletedDate.HasValue);




        }

    }
}
