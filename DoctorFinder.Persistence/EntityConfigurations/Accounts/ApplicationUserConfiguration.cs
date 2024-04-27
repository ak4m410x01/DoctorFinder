#region Using Directive Namespaces

using DoctorFinder.Domain.Enumerations;
using DoctorFinder.Domain.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion


namespace DoctorFinder.Persistence.EntityConfigurations.Accounts
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            #region Config Table Name

            // Config Table Name for ApplicationUser Entity
            builder.ToTable("Users", "Account");

            #endregion

            #region Config Primary Key

            builder.HasKey(x => x.Id);

            #endregion

            #region Config Properties

            builder.Property(x => x.Email)
                   .HasMaxLength(256)
                   .IsRequired();

            builder.Property(x => x.UserName)
                   .HasMaxLength(256)
                   .IsRequired();

            builder.Property(x => x.PasswordHash)
                   .IsRequired();

            builder.Property(x => x.FirstName)
                   .HasMaxLength(100)
                   .IsRequired(false);

            builder.Property(x => x.LastName)
                   .HasMaxLength(100)
                   .IsRequired(false);

            builder.Property(x => x.Image)
                   .IsRequired(false);

            builder.Property(x => x.BirthDate)
                   .IsRequired(false);

            builder.Property(x => x.Gender)
                   .HasConversion<byte>()
                   .HasDefaultValue(Gender.UnSet)
                   .HasSentinel(Gender.UnSet)
                   .IsRequired(false);

            builder.Property(x => x.Location)
                   .IsRequired(false);



            builder.OwnsOne(x => x.Address, a =>
            {
                a.Property(x => x.Country).HasMaxLength(100).HasColumnName("Country").IsRequired();
                a.Property(x => x.City).HasMaxLength(100).HasColumnName("City").IsRequired();
                a.Property(x => x.PostalCode).HasMaxLength(100).HasColumnName("PostalCode").IsRequired();
                a.Property(x => x.Street).HasMaxLength(100).HasColumnName("Street").IsRequired();
                a.Property(x => x.Floor).HasMaxLength(100).HasColumnName("Floor").IsRequired();
                a.Property(x => x.Apartment).HasMaxLength(100).HasColumnName("Apartment").IsRequired();
                a.Property(x => x.State).HasMaxLength(100).HasColumnName("State").IsRequired();
            });

            builder.Property(x => x.CreatedAt)
                   .HasDefaultValueSql("GETUTCDATE()")
                   .ValueGeneratedOnAdd();

            #endregion

            #region Config Inheritance Mapping Strategy

            // Config Inheritance as TPC
            builder.UseTptMappingStrategy();

            #endregion
        }
    }
}
