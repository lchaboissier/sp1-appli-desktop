using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;

namespace sp1_desktop.Models
{
    class Vehicle
    {
        public int Id { get; set; }
        public string Matriculation { get; set; }
        public string Client_company { get; set; }
        public string Driver { get; set; }
        public string State { get; set; }
        public string Vehicle_model { get; set; }
        //public string Driver { get; set; }
        public string Booking_status { get; set; }

        public static List<Vehicle> ForClient(int idClient, int halfDay, int bookingStatusId)
        {
            // Call the secure HTTP GET request
            IRestResponse response = Api.GetWithToken("vehiclesForClient/"+idClient+"/"+halfDay+"/"+bookingStatusId);

            // Create a array of objects instances of the class using the JSON response
            List<Vehicle> vehicles = JsonConvert.DeserializeObject<List<Vehicle>>(response.Content);

            return vehicles;
        }

        //public static List<Vehicle> Find(int IdVehicle)
        //{
        // Call the secure HTTP GET request with an id parameter
        //IRestResponse response = Api.GetWithToken("category/{id}", new Dictionary<string, string>() { { "id", IdVehicle.ToString() } });
        //
        // For debug
        //Console.WriteLine("vehiclesForClient/{id}/{id}/{id}", IdVehicle);
        //Console.WriteLine(response.Content);
        //
        // Create a object instance of the class using the JSON response
        //List<Vehicle> vehicle = JsonConvert.DeserializeObject<List<Vehicle>>(response.Content);
        //
        //return vehicle;
        //}
        // Call the secure HTTP GET request

        // For debug

        // Create a array of objects instances of the class using the JSON response
    }
}