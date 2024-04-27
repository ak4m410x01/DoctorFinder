#region Using Directive Namespaces

using DoctorFinder.Domain.Entities.Appointments;
using DoctorFinder.Domain.Entities.Reviews;
using DoctorFinder.Domain.Identity;

#endregion


namespace DoctorFinder.Domain.Entities.Accounts
{
    public class Patient : ApplicationUser
    {
        #region Appointment Relationship

        public ICollection<Appointment>? Appointments { get; set; }

        #endregion

        #region Review Relationship

        public ICollection<Review>? Reviews { get; set; }

        #endregion
    }
}
