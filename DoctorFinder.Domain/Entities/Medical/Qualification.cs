using DoctorFinder.Domain.Common.Abstractions;

namespace DoctorFinder.Domain.Entities.Medical
{
    public class Qualification : BaseEntity
    {
        public string Degree { get; set; } = default!;
        public string? Certification { get; set; }
        public string? Description { get; set; }
        public ushort YearsOfExperience { get; set; }

        public ICollection<DoctorQualifications>? Doctors { get; set; }
    }
}
