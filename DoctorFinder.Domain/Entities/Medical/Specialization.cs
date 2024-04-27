#region Using Directive Namespaces

using DoctorFinder.Domain.Common.Abstractions;
using DoctorFinder.Domain.Entities.Accounts;

#endregion


namespace DoctorFinder.Domain.Entities.Medical
{
    public class Specialization : BaseEntity
    {
        #region Properties

        public string Name { get; set; } = default!;
        public string Category { get; set; } = default!;
        public string? Description { get; set; }

        #endregion

        #region Doctor Relationship

        public ICollection<Doctor>? Doctors { get; set; }

        #endregion
    }
}
