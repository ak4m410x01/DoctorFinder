#region Using Directive Namespaces

using DoctorFinder.Domain.Entities.Medical;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion


namespace DoctorFinder.Persistence.EntityConfigurations.Medical
{
    public class QualificationConfiguration : IEntityTypeConfiguration<Qualification>
    {
        public void Configure(EntityTypeBuilder<Qualification> builder)
        {
            #region Config Table Name

            // Config Table Name for Qualification Entity
            builder.ToTable("Qualifications", "Medical");

            #endregion

            #region Primary Key

            builder.HasKey(x => x.Id);

            #endregion

            #region Config Properties

            builder.Property(x => x.Degree)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(x => x.Certification)
                   .HasMaxLength(100)
                   .IsRequired(false);

            builder.Property(x => x.Description)
                   .HasMaxLength(100)
                   .IsRequired(false);

            builder.Property(x => x.YearsOfExperience)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(x => x.CreatedAt)
                   .HasDefaultValueSql("GETUTCDATE()")
                   .ValueGeneratedOnAdd();

            #endregion
        }
    }
}