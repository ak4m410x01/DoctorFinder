#region Using Directive Namespaces

using DoctorFinder.Domain.Common.Abstractions;

#endregion


namespace DoctorFinder.Domain.Entities.Medical
{
    public class Qualification : BaseEntity
    {
        #region Properties

        public string Degree { get; set; } = default!;
        public string? Certification { get; set; }
        public string? Description { get; set; }
        public ushort YearsOfExperience { get; set; }

        #endregion

        #region DoctorQualifications Relationship

        public ICollection<DoctorQualifications>? Doctors { get; set; }

        #endregion
    }
}
