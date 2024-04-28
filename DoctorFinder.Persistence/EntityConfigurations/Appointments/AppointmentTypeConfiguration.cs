#region Using Directive Namespaces

using DoctorFinder.Domain.Entities.Appointments;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion

namespace DoctorFinder.Persistence.EntityConfigurations.Appointments
{
    public class AppointmentTypeConfiguration : IEntityTypeConfiguration<AppointmentType>
    {
        public void Configure(EntityTypeBuilder<AppointmentType> builder)
        {
            #region Config Table Name

            // Config Table Name for Appointment Type Entity
            builder.ToTable("AppointmentTypes", "Appointment");

            #endregion

            #region Config Primary Key

            builder.HasKey(x => x.Id);

            #endregion

            #region Config Properties

            builder.Property(x => x.Name)
                   .HasMaxLength(256)
                   .IsRequired();

            builder.Property(x => x.Description)
                   .HasMaxLength(2_000)
                   .IsRequired(false);

            builder.Property(x => x.Price)
                   .HasColumnType("decimal(5,2)");

            #endregion
        }
    }
}
