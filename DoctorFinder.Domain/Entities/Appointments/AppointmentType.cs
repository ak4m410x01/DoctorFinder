#region Using Directive Namespaces

using DoctorFinder.Domain.Common.Abstractions;

#endregion


namespace DoctorFinder.Domain.Entities.Appointments
{
    public class AppointmentType : BaseEntity
    {
        #region Properties

        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public decimal Price { get; set; }

        #endregion


        #region Appointment Relationship

        public ICollection<Appointment>? Appointments { get; set; }

        #endregion
    }
}
