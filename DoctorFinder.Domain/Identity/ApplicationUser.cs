﻿using Microsoft.AspNetCore.Identity;

namespace DoctorFinder.Domain.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}