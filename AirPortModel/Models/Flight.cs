using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AirPortModel.Models
{
    class Flight
    {
        [Key]
        public int FlightId { get; set; }
        //foriegn key ? ? ? :(
        public int FlightAirPlaneId { get; set; }
        // ??
        public int AirPortId { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public DateTime FlightTime { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FlighttDate { get; set; }

        public int FlightstatusId { get; set; }
        public int StartAirPortId { get; set; }
        public int FlightEndAirportId { get; set; }
        public int FlightGetId { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString ="{0:yyyy-mm-dd}")]
        public DateTime FlightStartTimeDate { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString ="{0:yyyy-mm-dd}")]
        public DateTime FlightEndTimeDate { get; set; }

    }
}
