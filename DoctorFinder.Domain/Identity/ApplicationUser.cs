#region Using Directive Namespaces

using DoctorFinder.Domain.Enumerations;
using DoctorFinder.Domain.ValueObjects;
using Microsoft.AspNetCore.Identity;

#endregion

namespace DoctorFinder.Domain.Identity
{
    public class ApplicationUser : IdentityUser
    {
        #region Properties

        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string? Image { get; set; }

        public DateOnly? BirthDate { get; set; }

        public Gender? Gender { get; set; }

        public Address? Address { get; set; }
        public string? Location { get; set; }

        public DateTime CreatedAt { get; }

        #endregion
    }
}
