
using System.Drawing;

namespace Kreta.Shared.Models
{
    public class Address : IDbEntity<Address>
    {
        public Address()
        {
            Id = Guid.Empty;
            City = string.Empty;
            StreetName = string.Empty;
            House = -1;
            Floor = -1;
            Door = -1;
            PostalCode = -1;

        }
        public Address(Guid id, string city, string streetName, int house, int floor, int door, int postalCode)
        {
            Id = id;
            City = city;
            StreetName = streetName;
            House = house;
            Floor = floor;
            Door = door;
            PostalCode = postalCode;
        }

        public Guid Id { get; set; }
        public string City { get; set; }
        public string StreetName { get; set; }
        public int House { get; set; }
        public int Floor { get; set; }
        public int Door { get; set; }
        public int PostalCode { get; set; }

        public bool HasId => Id !=Guid.Empty;
    }
}
