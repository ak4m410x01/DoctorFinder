#region Using Directive Namespaces

using DoctorFinder.Domain.Entities.Accounts;

#endregion


namespace DoctorFinder.Domain.Entities.Medical
{
    public class DoctorQualifications
    {
        #region Doctor Relationship

        public string DoctorId { get; set; } = default!;
        public Doctor? Doctor { get; set; }

        #endregion

        #region Qualification Relationship

        public uint QualificationId { get; set; }
        public Qualification? Qualification { get; set; }

        #endregion
    }
}
