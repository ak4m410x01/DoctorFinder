#region Using Directive Namespaces

using DoctorFinder.Domain.Entities.Reviews;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion


namespace DoctorFinder.Persistence.EntityConfigurations.Reviews
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            #region Config Table Name

            // Config Table Name for ApplicationUser Entity
            builder.ToTable("Reviews", "Reviews");

            #endregion

            #region Primary Key

            builder.HasKey(x => x.Id);

            #endregion

            #region Config Properties

            builder.Property(x => x.Stars)
                   .HasConversion<byte>()
                   .IsRequired();

            builder.Property(x => x.Comment)
                   .HasMaxLength(1_000)
                   .IsRequired(false);

            builder.Property(x => x.CreatedAt)
                   .HasDefaultValueSql("GETUTCDATE()")
                   .ValueGeneratedOnAdd();

            #endregion

            #region Config Relationship

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

            #endregion

            #region Config Constraints

            builder.HasIndex(x => new { x.DoctorId, x.PatientId })
                   .IsUnique();

            #endregion
        }
    }
}
