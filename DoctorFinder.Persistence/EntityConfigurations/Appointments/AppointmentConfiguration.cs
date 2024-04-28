#region Using Directive Namespaces

using DoctorFinder.Domain.Entities.Appointments;
using DoctorFinder.Domain.Enumerations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion


namespace DoctorFinder.Persistence.EntityConfigurations.Appointments
{
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            #region Config Table Name

            // Config Table Name for Appointment Entity
            builder.ToTable("Appointments", "Appointment");

            #endregion

            #region Config Primary Key

            builder.HasKey(x => x.Id);

            #endregion

            #region Config Properties

            builder.Property(x => x.Status)
                   .HasConversion<byte>()
                   .HasDefaultValue(AppointmentStatus.Pending)
                   .HasSentinel(AppointmentStatus.UnSet);

            builder.Property(x => x.Discount)
                   .HasColumnType("decimal(5,2)");

            builder.Property(x => x.CreatedAt)
                   .HasDefaultValueSql("GETUTCDATE()")
                   .ValueGeneratedOnAdd();

            #endregion


            #region Config Relationships

            // Appointment => Doctor
            builder.HasOne(x => x.Doctor)
                   .WithMany(y => y.Appointments)
                   .HasForeignKey(x => x.DoctorId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);

            // Appointment => Patient
            builder.HasOne(x => x.Patient)
                   .WithMany(y => y.Appointments)
                   .HasForeignKey(x => x.PatientId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);

            // Appointment => Appointment Type
            builder.HasOne(x => x.AppointmentType)
                   .WithMany(y => y.Appointments)
                   .HasForeignKey(x => x.AppointmentTypeId)
                   .IsRequired();

            #endregion

            #region Config Constraints

            builder.HasIndex(x => new { x.DoctorId, x.PatientId, x.DateTime })
                   .IsUnique();

            #endregion
        }
    }
}
