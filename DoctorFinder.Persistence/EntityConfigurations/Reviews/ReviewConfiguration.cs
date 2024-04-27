using DoctorFinder.Domain.Entities.Reviews;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DoctorFinder.Persistence.EntityConfigurations.Reviews
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            // Config Table Name for ApplicationUser Entity
            builder.ToTable("Reviews", "Reviews");

            // Config Properties
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Stars)
                   .HasConversion<byte>()
                   .IsRequired();

            builder.Property(x => x.Comment)
                   .HasMaxLength(1_000)
                   .IsRequired(false);

            builder.Property(x => x.CreatedAt)
                   .HasDefaultValueSql("GETUTCDATE()")
                   .ValueGeneratedOnAdd();

            // Config Relationship
            builder.HasOne(x => x.Doctor)
                   .WithMany(y => y.Reviews)
                   .HasForeignKey(x => x.DoctorId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Patient)
                   .WithMany(y => y.Reviews)
                   .HasForeignKey(x => x.PatientId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);

            // Config Index
            builder.HasIndex(x => new { x.DoctorId, x.PatientId })
                   .IsUnique();
        }
    }
}
