namespace DoctorFinder.Domain.Common.Abstractions
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; } = DateTime.Now;
    }
}
