#region Using Directive Namespaces

using DoctorFinder.Domain.Entities.Medical;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion


namespace DoctorFinder.Persistence.EntityConfigurations.Medical
{
    public class SpecializationConfiguration : IEntityTypeConfiguration<Specialization>
    {
        public void Configure(EntityTypeBuilder<Specialization> builder)
        {
            #region Config Table Name

            // Config Table Name for Specialization Entity
            builder.ToTable("Specializations", "Medical");

            #endregion


            #region Primary Key

            builder.HasKey(x => x.Id);

            #endregion

            #region Config Properties

            builder.Property(x => x.Name)
                   .HasMaxLength(256)
                   .IsRequired();

            builder.Property(x => x.Category)
                   .HasMaxLength(256)
                   .IsRequired();

            builder.Property(x => x.Description)
                   .HasMaxLength(5_000)
                   .IsRequired(false);

            builder.Property(x => x.CreatedAt)
                   .HasDefaultValueSql("GETUTCDATE()")
                   .ValueGeneratedOnAdd();

            #endregion
        }
    }
}
