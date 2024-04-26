using DoctorFinder.Domain.Entities.Accounts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DoctorFinder.Persistence.EntityConfigurations.Account
{
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            // Config Table Name for Doctor Entity
            builder.ToTable("Doctors", "Account");

            // Config Relationships
            builder.HasOne(x => x.Specialization)
                   .WithMany(y => y.Doctors)
                   .HasForeignKey(x => x.SpecializationId)
                   .IsRequired(false);
        }
    }
}
