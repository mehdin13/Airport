using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirPort.Model.ViewModel
{
    public class FlightViewModel
    {
        public string Number { get; set; }//flight number
        public string AirplainName { get; set; }
        public string AirPortName { get; set; }
        public string FlightStatus { get; set; }
        public string StartAirPort { get; set; }
        public string EndAirPortId { get; set; }
        public string Gate { get; set; }
        public string Weather { get; set; }
        public string Temperature { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime StartTime { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime EndTime { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Delay { get; set; }
    }
    public class AddtoFlightList
    {
        public int Flightid { get; set; }
    }
}
