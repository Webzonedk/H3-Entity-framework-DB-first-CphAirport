//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CphAirport
{
    using System;
    using System.Collections.Generic;
    
    public partial class FlightPlan
    {
        public int id { get; set; }
        public System.DateTime departtureTime { get; set; }
        public System.DateTime arrivalTime { get; set; }
        public int operatorID { get; set; }
        public int ownerID { get; set; }
        public int routeID { get; set; }
        public int airPlane { get; set; }
    
        public virtual AirLine AirLine { get; set; }
        public virtual AirLine AirLine1 { get; set; }
        public virtual AirPlane AirPlane1 { get; set; }
        public virtual FlightRoute FlightRoute { get; set; }
    }
}