#region Using Directive Namespaces

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion


namespace DoctorFinder.Persistence.EntityConfigurations.Security
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            #region Config Table Name

            // Config Table Name for IdentityRole Entity
            builder.ToTable("Roles", "Security");

            #endregion
        }
    }
}
