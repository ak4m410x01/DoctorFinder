using DoctorFinder.Domain.Entities.Appointments;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DoctorFinder.Persistence.EntityConfigurations.Appointments
{
    public class WorkScheduleConfiguration : IEntityTypeConfiguration<WorkSchedule>
    {
        public void Configure(EntityTypeBuilder<WorkSchedule> builder)
        {
            // Config Table Name for Qualification Entity
            builder.ToTable("WorkSchedules", "Appointment");

            // Config Properties
            builder.HasKey(x => new { x.DoctorId, x.DayOfWeek });

            builder.Property(x => x.DayOfWeek)
                   .HasConversion<ushort>()
                   .IsRequired();

            // Config Relationship
            builder.HasOne(x => x.Doctor)
                   .WithMany(y => y.WorkSchedules)
                   .HasForeignKey(x => x.DoctorId)
                   .IsRequired();
        }
    }
}
