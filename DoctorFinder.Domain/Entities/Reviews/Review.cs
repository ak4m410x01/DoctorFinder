#region Using Directive Namespaces

using DoctorFinder.Domain.Common.Abstractions;
using DoctorFinder.Domain.Entities.Accounts;
using DoctorFinder.Domain.Enumerations;

#endregion


namespace DoctorFinder.Domain.Entities.Reviews
{
    public class Review : BaseEntity
    {
        #region Properties

        public ReviewStars Stars { get; set; }
        public string? Comment { get; set; }

        #endregion

        #region Patient Relationship

        public string PatientId { get; set; } = default!;
        public Patient? Patient { get; set; }

        #endregion

        #region Doctor Relationship

        public string DoctorId { get; set; } = default!;
        public Doctor? Doctor { get; set; }

        #endregion
    }
}
