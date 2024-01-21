using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class VirtualClassConfiguration : IEntityTypeConfiguration<VirtualClass>
    {
        public void Configure(EntityTypeBuilder<VirtualClass> builder)
        {
            builder.ToTable("VirtualClasses").HasKey(t => t.Id);
            builder.Property(t => t.Id).HasColumnName("Id").IsRequired();
            builder.Property(t => t.TopicId).HasColumnName("TopicId").IsRequired();
            builder.Property(t => t.StartTime).HasColumnName("StartTime").IsRequired();
            builder.Property(t => t.FinishTime).HasColumnName("FinishTime").IsRequired();

            builder.HasOne(v=>v.Topic).WithMany(t=>t.VirtualClasses).HasForeignKey(v=>v.TopicId);
            //Instructor ile virtual class arasında n-n ilişki var. Ara tablo yapılmalı mı? 

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);


        }
    }
}
