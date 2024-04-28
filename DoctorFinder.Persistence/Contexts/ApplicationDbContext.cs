#region Using Directive Namespaces

using DoctorFinder.Domain.Entities.Accounts;
using DoctorFinder.Domain.Entities.Appointments;
using DoctorFinder.Domain.Entities.Medical;
using DoctorFinder.Domain.Entities.Reviews;
using DoctorFinder.Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

#endregion

namespace DoctorFinder.Persistence.Contexts
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        #region Constructors

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        #endregion

        #region DbSets Configuration

        // Configure Db Sets

        // Account Entities
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }

        // Medical Entities
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
        public DbSet<DoctorQualifications> DoctorQualifications { get; set; }

        // Appointment Entities
        public DbSet<WorkSchedule> WorkSchedules { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<AppointmentType> AppointmentTypes { get; set; }

        // Review Entity
        public DbSet<Review> Reviews { get; set; }

        #endregion


        #region On Model Creating Configuration

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            #region Identity Configuration

            // Config Identity Tables Names
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles", "Security");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims", "Security");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins", "Security");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims", "Security");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens", "Security");

            #endregion

            #region Assemblies Configuration

            // Apply Entities Configurations
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            #endregion
        }

        #endregion
    }
}
