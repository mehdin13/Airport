using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AirPortModel.Models
{
    class Flight
    {
        public int FlightId { get; set; }
        public int FlightAirPlaneId { get; set; }
        public int AirPortId { get; set; }

        [DataType(DataType.Time)]
        public DateTime FlightTime { get; set; }

        [DataType(DataType.Date)]
        public DateTime FlighttDate { get; set; }

        public int FlightstatusId { get; set; }
        public int StartAirPortId { get; set; }
        public int FlightEndAirportId { get; set; }
        public int FlightGetId { get; set; }
        public DataType FlightStartTimeDate { get; set; }
        public DataType FlightEndTimeDate { get; set; }

    }
}
