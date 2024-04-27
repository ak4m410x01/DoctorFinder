using DoctorFinder.Domain.Common.Abstractions;
using DoctorFinder.Domain.Entities.Accounts;
using DoctorFinder.Domain.Enumerations;

namespace DoctorFinder.Domain.Entities.Appointments
{
    public class Appointment : BaseEntity
    {
        public DateTime DateTime { get; set; }
        public AppointmentStatus Status { get; set; }

        public string DoctorId { get; set; } = default!;
        public Doctor? Doctor { get; set; }

        public string PatientId { get; set; } = default!;
        public Patient? Patient { get; set; }
    }
}