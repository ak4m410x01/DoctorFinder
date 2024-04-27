using DoctorFinder.Domain.Entities.Accounts;

namespace DoctorFinder.Domain.Entities.Appointments
{
    public class WorkSchedule
    {
        public DayOfWeek DayOfWeek { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public string DoctorId { get; set; } = default!;
        public Doctor? Doctor { get; set; }
        public DateTime CreatedAt { get; }
    }
}