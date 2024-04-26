using DoctorFinder.Domain.Entities.Medical;
using DoctorFinder.Domain.Identity;

namespace DoctorFinder.Domain.Entities.Accounts
{
    public class Doctor : ApplicationUser
    {
        public int SpecializationId { get; set; }
        public Specialization? Specialization { get; set; }

        public ICollection<DoctorQualifications>? Qualifications { get; set; }
    }
}
