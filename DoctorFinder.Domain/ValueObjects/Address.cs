using DoctorFinder.Domain.Common.Abstractions;

namespace DoctorFinder.Domain.ValueObjects
{
    public class Address : BaseValueObject
    {
        public Address(string country, string city, string postalCode, string street, string floor, string apartment, string state)
        {
            Country = country;
            City = city;
            PostalCode = postalCode;
            Street = street;
            Floor = floor;
            Apartment = apartment;
            State = state;
        }

        public string Country { get; private set; }
        public string City { get; private set; }
        public string PostalCode { get; private set; }
        public string Street { get; private set; }
        public string Floor { get; private set; }
        public string Apartment { get; private set; }
        public string State { get; private set; }

        protected override IEnumerable<object> GetObjectValues()
        {
            return [Country, City, PostalCode, Street, Floor, Apartment, State];
        }
    }
}
