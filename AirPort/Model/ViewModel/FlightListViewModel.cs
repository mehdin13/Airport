using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirPort.Model.ViewModel
{
    public class FlightListViewModel
    {
        public string FlightNumber { get; set; }
        public int Airplaincode { get; set; }
        public string AirplainName { get; set; }
        public int airplainid { get; set; }
        public string AirlineIcon { get; set; }
        public string AirlineName { get; set; }
        public int AirlineId { get; set; }
        public int Flightid { get; set; }
        public string StartAirPort { get; set; }
        public string EndAirPort { get; set; }
        public string WeatherIcon { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime StartTime { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime EndTime { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Delay { get; set; }
    }
}
