using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;

namespace sp1_desktop.Models
{
    class Driver
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string PostalCode{ get; set; }
        public string City { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public bool DrivingLicense { get; set; }
        public string CompanyName { get; set; }

        // Construtor

        // Static methods for managing one or more records
        public static Driver All()
        {
            // Call the secure HTTP GET request
            IRestResponse response = Api.GetWithToken("driver");

            // For debug
            Console.WriteLine("Driver-All()");
            Console.WriteLine(response.Content);

            // Create a array of objects instances of the class using the JSON response
            Driver drivers = JsonConvert.DeserializeObject<Driver>(response.Content);

            return drivers;
        }
        // Call the secure HTTP GET request

        // For debug

        // Create a array of objects instances of the class using the JSON response
    }
}
