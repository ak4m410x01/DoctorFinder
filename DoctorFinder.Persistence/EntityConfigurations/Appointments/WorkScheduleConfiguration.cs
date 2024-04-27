#region Using Directive Namespaces

using DoctorFinder.Domain.Entities.Appointments;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion


namespace DoctorFinder.Persistence.EntityConfigurations.Appointments
{
    public class WorkScheduleConfiguration : IEntityTypeConfiguration<WorkSchedule>
    {
        public void Configure(EntityTypeBuilder<WorkSchedule> builder)
        {
            #region Config Table Name

            // Config Table Name for Qualification Entity
            builder.ToTable("WorkSchedules", "Appointment");

            #endregion

            #region Primary Key

            builder.HasKey(x => new { x.DoctorId, x.DayOfWeek });

            #endregion

            #region Config Properties

            builder.Property(x => x.DayOfWeek)
                   .HasConversion<byte>()
                   .IsRequired();

            builder.Property(x => x.CreatedAt)
                   .HasDefaultValueSql("GETUTCDATE()")
                   .ValueGeneratedOnAdd();

            #endregion

            #region Config Relationship

            builder.HasOne(x => x.Doctor)
                   .WithMany(y => y.WorkSchedules)
                   .HasForeignKey(x => x.DoctorId)
                   .IsRequired();

            #endregion
        }
    }
}
