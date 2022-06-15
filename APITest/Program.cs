using IO.Swagger.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamWorldwideAPI;
using TeamWorldwideModel;

namespace APITest
{
    internal class Program
    {
        string url = "https://api-drychlik.teamww.com";

        static void Main(string[] args)
        {
            Program program = new Program();


            Credentials credentials = new Credentials
            {
                Username = "daniel",
                Password = "password"
            };

            ApiClient apiClient = new ApiClient(program.url);

            try
            {
                Console.WriteLine("Trying: " + program.url + System.Environment.NewLine);

                AuthenticateApi authenticateApi = new AuthenticateApi(apiClient);
                authenticateApi.Authenticate(credentials);

                Console.WriteLine("Authenticated" + System.Environment.NewLine);

                // Fetch statuses by House-Bill
                ShipmentV2Api shipmentV2Api = new ShipmentV2Api(apiClient);

                Console.WriteLine("Fetching statuses" + System.Environment.NewLine);

                InlineResponse2004 shipmentStatus = shipmentV2Api.GetGetShipmentStatusCollection("EWRMNY22050307A");

                Console.WriteLine("Got " + shipmentStatus.HydratotalItems + " statuses" + System.Environment.NewLine);

                // Process the shipment statuses
                


            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + System.Environment.NewLine);
            }
        }
    }
}
