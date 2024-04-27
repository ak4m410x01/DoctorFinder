namespace DoctorFinder.Domain.Common.Abstractions
{
    public abstract class BaseValueObject
    {
        #region Abstract Methods

        protected abstract IEnumerable<object> GetEqualityComponents();

        #endregion


        #region Equals Override

        public override bool Equals(object? obj)
        {
            if (obj == null || obj.GetType() != GetType())
                return false;

            BaseValueObject other = (BaseValueObject)obj;

            return GetEqualityComponents()
                  .SequenceEqual(other.GetEqualityComponents());
        }

        #endregion

        #region GetHashCode Override

        public override int GetHashCode()
        {
            return GetEqualityComponents()
                  .Aggregate(17, (current, obj) => current * 23 + (obj?.GetHashCode() ?? 0));
        }

        #endregion


        #region Operator == Override

        public static bool operator ==(BaseValueObject obj1, BaseValueObject obj2)
        {
            if (obj1 is null)
                return obj2 is null;

            return obj1.Equals(obj2);
        }

        #endregion

        #region Operator != Override

        public static bool operator !=(BaseValueObject obj1, BaseValueObject obj2)
        {
            return !(obj1 == obj2);
        }

        #endregion
    }
}
