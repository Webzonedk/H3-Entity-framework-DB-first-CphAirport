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
    
    public partial class AirPort
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AirPort()
        {
            this.FlightRoutes = new HashSet<FlightRoute>();
            this.FlightRoutes1 = new HashSet<FlightRoute>();
        }
    
        public int id { get; set; }
        public string iataCode { get; set; }
        public string city { get; set; }
        public string country { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlightRoute> FlightRoutes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlightRoute> FlightRoutes1 { get; set; }
    }
}
