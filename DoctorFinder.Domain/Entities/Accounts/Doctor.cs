using DoctorFinder.Domain.Entities.Appointments;
using DoctorFinder.Domain.Entities.Medical;
using DoctorFinder.Domain.Entities.Reviews;
using DoctorFinder.Domain.Identity;

namespace DoctorFinder.Domain.Entities.Accounts
{
    public class Doctor : ApplicationUser
    {
        public int SpecializationId { get; set; }
        public Specialization? Specialization { get; set; }

        public ICollection<DoctorQualifications>? Qualifications { get; set; }
        public ICollection<WorkSchedule>? WorkSchedules { get; set; }
        public ICollection<Appointment>? Appointments { get; set; }
        public ICollection<Review>? Reviews { get; set; }
    }
}
