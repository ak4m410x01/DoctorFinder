namespace DoctorFinder.Domain.Common.Abstractions
{
    public abstract class BaseEntity
    {
        public uint Id { get; set; }
        public DateTime CreatedAt { get; }

        public override bool Equals(object? obj)
        {
            // Check for reference equality and nullity
            if (ReferenceEquals(this, obj))
                return true;

            if (obj is not BaseEntity other)
                return false;

            // If the types are different, they are not equal
            if (GetType() != other.GetType())
                return false;

            // If either other's ID is the default value, they are not equal
            return Id != default && Id == other.Id;
        }

        public override int GetHashCode()
        {
            return Id == default ? base.GetHashCode() : Id.GetHashCode();
        }
        public static bool operator ==(BaseEntity obj1, BaseEntity obj2)
        {
            if (obj1 is null)
                return obj2 is null;
            return obj1.Equals(obj2);
        }
        public static bool operator !=(BaseEntity obj1, BaseEntity obj2)
        {
            return !(obj1 == obj2);
        }
    }
}
