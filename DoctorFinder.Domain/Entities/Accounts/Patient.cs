using DoctorFinder.Domain.Entities.Appointments;
using DoctorFinder.Domain.Entities.Reviews;
using DoctorFinder.Domain.Identity;

namespace DoctorFinder.Domain.Entities.Accounts
{
    public class Patient : ApplicationUser
    {
        public ICollection<Appointment>? Appointments { get; set; }
        public ICollection<Review>? Reviews { get; set; }
    }
}
