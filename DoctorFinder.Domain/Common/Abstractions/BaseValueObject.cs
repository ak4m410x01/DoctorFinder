namespace DoctorFinder.Domain.Common.Abstractions
{
    public abstract class BaseValueObject
    {
        protected abstract IEnumerable<object> GetObjectValues();

        public override bool Equals(object? obj)
        {
            if (obj is null || obj.GetType() != GetType())
                return false;

            BaseValueObject other = (BaseValueObject)obj;

            return GetObjectValues().SequenceEqual(other.GetObjectValues());
        }

        public override int GetHashCode()
        {
            return GetObjectValues()
                  .Select(x => x is null ? 0 : x.GetHashCode())
                  .Aggregate((x, y) => x ^ y);
        }

        public static bool operator ==(BaseValueObject objA, BaseValueObject objB)
        {
            if (objA is null)
                return objB is null;

            return objA.Equals(objB);
        }

        public static bool operator !=(BaseValueObject left, BaseValueObject right)
        {
            return !(left == right);
        }
    }
}
