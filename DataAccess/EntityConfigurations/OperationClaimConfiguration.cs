using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class OperationClaimConfiguration : IEntityTypeConfiguration<OperationClaim>
    {
        public void Configure(EntityTypeBuilder<OperationClaim> builder)
        {


            builder.ToTable("OperationClaims").HasKey(oc => oc.Id);

            builder.Property(oc => oc.Id).HasColumnName("Id").IsRequired();
            builder.Property(oc => oc.Name).HasColumnName("Name").IsRequired();
            builder.Property(oc => oc.CreatedDate).HasColumnName("CreatedDate").IsRequired();
            builder.Property(oc => oc.UpdatedDate).HasColumnName("UpdatedDate");
            builder.Property(oc => oc.DeletedDate).HasColumnName("DeletedDate");

            builder.HasQueryFilter(oc => !oc.DeletedDate.HasValue);




        }


    }
}
