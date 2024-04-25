using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DoctorFinder.Persistence.EntityConfigurations.Security
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            // Config Table Name for IdentityRole Entity
            builder.ToTable("Roles", "Security");
        }
    }
}
