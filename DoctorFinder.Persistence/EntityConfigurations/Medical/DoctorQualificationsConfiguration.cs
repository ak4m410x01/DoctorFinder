using DoctorFinder.Domain.Entities.Medical;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DoctorFinder.Persistence.EntityConfigurations.Medical
{
    public class DoctorQualificationsConfiguration : IEntityTypeConfiguration<DoctorQualifications>
    {
        public void Configure(EntityTypeBuilder<DoctorQualifications> builder)
        {
            // Config Table Name for Qualification Entity
            builder.ToTable("DoctorQualifications", "Medical");

            // Config Properties
            builder.HasKey(x => new { x.DoctorId, x.QualificationId });

            // Config Relationships
            builder.HasOne(x => x.Doctor)
                   .WithMany(y => y.Qualifications)
                   .HasForeignKey(x => x.DoctorId)
                   .IsRequired();

            builder.HasOne(x => x.Qualification)
                   .WithMany(y => y.Doctors)
                   .HasForeignKey(x => x.QualificationId)
                   .IsRequired();
        }
    }
}
