using DoctorFinder.Domain.Entities.Medical;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DoctorFinder.Persistence.EntityConfigurations.Medical
{
    public class QualificationConfiguration : IEntityTypeConfiguration<Qualification>
    {
        public void Configure(EntityTypeBuilder<Qualification> builder)
        {
            // Config Table Name for Qualification Entity
            builder.ToTable("Qualifications", "Medical");

            // Config Properties
            builder.HasKey(x => x.Id);

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
        }
    }
}