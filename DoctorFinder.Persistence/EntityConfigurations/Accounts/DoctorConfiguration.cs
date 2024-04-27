#region Using Directive Namespaces

using DoctorFinder.Domain.Entities.Accounts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion


namespace DoctorFinder.Persistence.EntityConfigurations.Accounts
{
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            #region Config Table Name

            // Config Table Name for Doctor Entity
            builder.ToTable("Doctors", "Account");

            #endregion

            #region Config Relationships

            // Doctors => Specialization
            builder.HasOne(x => x.Specialization)
                   .WithMany(y => y.Doctors)
                   .HasForeignKey(x => x.SpecializationId)
                   .IsRequired(false);

            #endregion
        }
    }
}
