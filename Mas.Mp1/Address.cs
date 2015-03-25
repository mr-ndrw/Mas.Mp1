using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mas.Mp1
{
    public class Address
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Object"/> class.
        /// </summary>
        public Address(string streetName, string buildingNumber, string premisesNumber, string city, string zipPostalCode, string region, string country)
        {
            StreetName = streetName;
            BuildingNumber = buildingNumber;
            PremisesNumber = premisesNumber;
            City = city;
            ZipPostalCode = zipPostalCode;
            Region = region;
            Country = country;
        }       
        public string StreetName { get; set; }
        public string BuildingNumber { get; set; }
        public string PremisesNumber { get; set; }
        public string City { get; set; }
        public string ZipPostalCode { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }

    }
}
