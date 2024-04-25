using DoctorFinder.Domain.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DoctorFinder.Persistence.EntityConfigurations.Users
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            // Config Table Name for ApplicationUser Entity
            builder.ToTable("Users", "Account");


            // Config Properties
            builder.HasKey(x => x.Id);

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


            // Config Inheritance as TPC
            builder.UseTptMappingStrategy();
        }
    }
}
