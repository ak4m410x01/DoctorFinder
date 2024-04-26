using DoctorFinder.Domain.Common.Abstractions;
using DoctorFinder.Domain.Entities.Accounts;

namespace DoctorFinder.Domain.Entities.Reviews
{
    public class Review : BaseEntity
    {
        public ushort Stars { get; set; }
        public string? Comment { get; set; }

        public string PatientId { get; set; } = default!;
        public Patient? Patient { get; set; }

        public string DoctorId { get; set; } = default!;
        public Doctor? Doctor { get; set; }
    }
}
