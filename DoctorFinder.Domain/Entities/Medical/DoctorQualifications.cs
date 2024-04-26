using DoctorFinder.Domain.Entities.Accounts;

namespace DoctorFinder.Domain.Entities.Medical
{
    public class DoctorQualifications
    {
        public string DoctorId { get; set; } = default!;
        public Doctor? Doctor { get; set; }

        public int QualificationId { get; set; }
        public Qualification? Qualification { get; set; }
    }
}
