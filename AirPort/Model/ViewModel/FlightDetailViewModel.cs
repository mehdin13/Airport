﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirPort.Model.ViewModel
{
    public class FlightDetailViewModel
    {
        public string Number { get; set; }
        public string Airplain { get; set; }
        public string AirPort { get; set; }
        public string FlightStatus { get; set; }
        public string StartAirPort { get; set; }
        public string EndAirPort { get; set; }
        public string Gate { get; set; }
        
        public string StartAirportWeather { get; set; }
        public string EndAirportWeather { get; set; }

        public string StartAirportTemperature { get; set; }
        public string EndAirportTemperature { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime StartTime { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime EndTime { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Delay { get; set; }
    }
}
