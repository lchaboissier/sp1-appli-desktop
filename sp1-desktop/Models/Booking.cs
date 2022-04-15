using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;

namespace sp1_desktop.Models
{
    class Booking
    {
        public int Id { get; set; }
        public int? Driver_id{ get; set; }
        public int? Vehicle_id { get; set; }
        public DateTime dateTime { get; set; }
        public int halfDay { get; set; }
        public bool active { get; set; }
        public int? Booking_Status_id { get; set; }
        public int? Trip_Type_id { get; set; }
        public int? Company_id { get; set; }

        // Construtor

        // Static methods for managing one or more records
        public static Booking All()
        {
            // Call the secure HTTP GET request
            IRestResponse response = Api.GetWithToken("booking");

            // Create a array of objects instances of the class using the JSON response
            Booking bookings = JsonConvert.DeserializeObject<Booking>(response.Content);

            return bookings;
        }
        public static Booking ActiveAgencyBookings()
        {
            // Call the secure HTTP GET request
            IRestResponse response = Api.GetWithToken("booking");

            // For debug
            Console.WriteLine("Booking-ActiveAgencyBookings()");
            Console.WriteLine(response.Content);

            // Create a array of objects instances of the class using the JSON response
            Booking bookings = JsonConvert.DeserializeObject<Booking>(response.Content);

            return bookings;
        }
        // Call the secure HTTP GET request

        // For debug

        // Create a array of objects instances of the class using the JSON response
    }
}
