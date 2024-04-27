#region Using Directive Namespaces

using DoctorFinder.Domain.Entities.Appointments;
using DoctorFinder.Domain.Entities.Medical;
using DoctorFinder.Domain.Entities.Reviews;
using DoctorFinder.Domain.Identity;

#endregion


namespace DoctorFinder.Domain.Entities.Accounts
{
    public class Doctor : ApplicationUser
    {
        #region Specialization Relationship

        public uint SpecializationId { get; set; }
        public Specialization? Specialization { get; set; }

        #endregion


        #region DoctorQualifications Relationship

        public ICollection<DoctorQualifications>? Qualifications { get; set; }

        #endregion

        #region WorkSchedule Relationship

        public ICollection<WorkSchedule>? WorkSchedules { get; set; }

        #endregion

        #region Appointment Relationship

        public ICollection<Appointment>? Appointments { get; set; }

        #endregion

        #region Review Relationship

        public ICollection<Review>? Reviews { get; set; }

        #endregion
    }
}
