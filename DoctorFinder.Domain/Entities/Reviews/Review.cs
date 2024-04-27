using DoctorFinder.Domain.Common.Abstractions;
using DoctorFinder.Domain.Entities.Accounts;
using DoctorFinder.Domain.Enumerations;

namespace DoctorFinder.Domain.Entities.Reviews
{
    public class Review : BaseEntity
    {
        public ReviewStars Stars { get; set; }
        public string? Comment { get; set; }

        public string PatientId { get; set; } = default!;
        public Patient? Patient { get; set; }

        public string DoctorId { get; set; } = default!;
        public Doctor? Doctor { get; set; }
    }
}
