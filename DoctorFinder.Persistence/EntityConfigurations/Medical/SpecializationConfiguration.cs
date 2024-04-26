using DoctorFinder.Domain.Entities.Medical;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DoctorFinder.Persistence.EntityConfigurations.Medical
{
    public class SpecializationConfiguration : IEntityTypeConfiguration<Specialization>
    {
        public void Configure(EntityTypeBuilder<Specialization> builder)
        {
            // Config Table Name for Specialization Entity
            builder.ToTable("Specializations", "Medical");

            // Config Properties
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                   .HasMaxLength(256)
                   .IsRequired();

            builder.Property(x => x.Category)
                   .HasMaxLength(256)
                   .IsRequired();

            builder.Property(x => x.Description)
                   .HasMaxLength(5_000)
                   .IsRequired(false);
        }
    }
}
