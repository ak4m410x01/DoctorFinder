using DoctorFinder.Domain.Common.Abstractions;
using DoctorFinder.Domain.Entities.Accounts;

namespace DoctorFinder.Domain.Entities.Medical
{
    public class Specialization : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string Category { get; set; } = default!;
        public string? Description { get; set; }

        public ICollection<Doctor>? Doctors { get; set; }
    }
}
