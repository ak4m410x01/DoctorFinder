using DoctorFinder.Domain.Entities.Appointments;
using DoctorFinder.Domain.Enumerations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DoctorFinder.Persistence.EntityConfigurations.Appointments
{
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            // Config Table Name for Appointment Entity
            builder.ToTable("Appointments", "Appointment");

            // Config Properties
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Status)
                   .HasConversion<byte>()
                   .HasDefaultValue(AppointmentStatus.Pending)
                   .HasSentinel(AppointmentStatus.UnSet);

            builder.Property(x => x.CreatedAt)
                   .HasDefaultValueSql("GETUTCDATE()")
                   .ValueGeneratedOnAdd();

            // Config Relationship
            builder.HasOne(x => x.Doctor)
                   .WithMany(y => y.Appointments)
                   .HasForeignKey(x => x.DoctorId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Patient)
                   .WithMany(y => y.Appointments)
                   .HasForeignKey(x => x.PatientId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);

            // Config Constraint
            builder.HasIndex(x => new { x.DoctorId, x.PatientId, x.DateTime })
                   .IsUnique();
        }
    }
}
