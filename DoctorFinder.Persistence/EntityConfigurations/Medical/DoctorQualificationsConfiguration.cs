#region Using Directive Namespaces

using DoctorFinder.Domain.Entities.Medical;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion


namespace DoctorFinder.Persistence.EntityConfigurations.Medical
{
    public class DoctorQualificationsConfiguration : IEntityTypeConfiguration<DoctorQualifications>
    {
        public void Configure(EntityTypeBuilder<DoctorQualifications> builder)
        {
            #region Config Table Name

            // Config Table Name for Qualification Entity
            builder.ToTable("DoctorQualifications", "Medical");

            #endregion

            #region Primary Key

            builder.HasKey(x => new { x.DoctorId, x.QualificationId });

            #endregion

            #region Config Relationships

            builder.HasOne(x => x.Doctor)
                   .WithMany(y => y.Qualifications)
                   .HasForeignKey(x => x.DoctorId)
                   .IsRequired();

            builder.HasOne(x => x.Qualification)
                   .WithMany(y => y.Doctors)
                   .HasForeignKey(x => x.QualificationId)
                   .IsRequired();

            #endregion
        }
    }
}
