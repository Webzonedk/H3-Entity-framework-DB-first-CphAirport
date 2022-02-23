using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CphAirport
{
    class Program
    {
        //Creating a new instance of Controller
        static private Controller controller = new Controller();
        static void Main(string[] args)
        {
            //Running through the flight plan including a couple of other tables as well.
            List<FlightPlan> flightPlan = controller.GetFlightplans();
            foreach (FlightPlan flight in flightPlan)
            {
                Console.WriteLine($"Departure: {flight.departtureTime} |--| Arrival:{flight.arrivalTime} |--| Flight nr.: {flight.AirPlane1.id} |--| Type: {flight.AirPlane1.flightType} |--| flying from: {flight.FlightRoute.AirPort.city} |--| to: {flight.FlightRoute.AirPort1.city}");
            }
            Console.ReadKey();
        }
    }
}
