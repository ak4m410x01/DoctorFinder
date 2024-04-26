using DoctorFinder.Domain.Entities.Appointments;
using DoctorFinder.Domain.Identity;

namespace DoctorFinder.Domain.Entities.Accounts
{
    public class Patient : ApplicationUser
    {
        public ICollection<Appointment>? Appointments { get; set; }
    }
}
