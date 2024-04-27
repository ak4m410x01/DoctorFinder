#region Using Directive Namespaces

using DoctorFinder.Domain.Common.Abstractions;
using DoctorFinder.Domain.Entities.Accounts;
using DoctorFinder.Domain.Enumerations;

#endregion


namespace DoctorFinder.Domain.Entities.Appointments
{
    public class Appointment : BaseEntity
    {
        #region Properties

        public DateTime DateTime { get; set; }
        public AppointmentStatus Status { get; set; }

        #endregion

        #region Doctor Relationship

        public string DoctorId { get; set; } = default!;
        public Doctor? Doctor { get; set; }

        #endregion

        #region Patient Relationship

        public string PatientId { get; set; } = default!;
        public Patient? Patient { get; set; }

        #endregion
    }
}