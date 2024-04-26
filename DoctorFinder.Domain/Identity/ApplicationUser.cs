using DoctorFinder.Domain.Enumerations;
using DoctorFinder.Domain.ValueObjects;
using Microsoft.AspNetCore.Identity;

namespace DoctorFinder.Domain.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string? Image { get; set; }

        public DateOnly? BirthDate { get; set; }

        public Gender Gender { get; set; } = Gender.Unspecified;

        public Address? Address { get; set; }
        public string? Location { get; set; }

        public DateTime CreatedAt { get; } = DateTime.Now;
    }
}
