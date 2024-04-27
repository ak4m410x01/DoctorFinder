#region Using Directive Namespaces

using DoctorFinder.Domain.Entities.Accounts;

#endregion


namespace DoctorFinder.Domain.Entities.Appointments
{
    public class WorkSchedule
    {
        #region Properties

        public DayOfWeek DayOfWeek { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public DateTime CreatedAt { get; }

        #endregion

        #region Doctor Relationship

        public string DoctorId { get; set; } = default!;
        public Doctor? Doctor { get; set; }

        #endregion
    }
}