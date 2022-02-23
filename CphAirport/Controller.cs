using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CphAirport
{
    class Controller
    {
        #region fields

        #endregion



        #region properties

        #endregion



        #region constructors

        public Controller()
        {

        }

        #endregion

        //Getting flightplan including tables connected to the forreign keys
        public List<FlightPlan> GetFlightplans()
        {

            using (var context = new CphAirportEntities())
            {
                var query = context.FlightPlans.Include(al => al.AirLine).Include(al => al.AirLine1).Include(ap => ap.AirPlane1).Include(fr => fr.FlightRoute.AirPort).Include(fr => fr.FlightRoute.AirPort1).ToList();

                return query;

            }
        }
    }
}