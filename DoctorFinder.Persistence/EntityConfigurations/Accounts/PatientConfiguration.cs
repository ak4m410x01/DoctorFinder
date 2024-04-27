#region Using Directive Namespaces

using DoctorFinder.Domain.Entities.Accounts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion


namespace DoctorFinder.Persistence.EntityConfigurations.Accounts
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            #region Config Table Name

            // Config Table Name for Patient Entity
            builder.ToTable("Patients", "Account");

            #endregion
        }
    }
}
