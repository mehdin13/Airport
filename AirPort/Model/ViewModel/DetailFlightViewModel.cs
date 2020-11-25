using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirPort.Model.ViewModel
{
    public class DetailFlightViewModel
    {
        public string AirportStartName { get; set; }
        public string AirportEnd { get; set; }
        public string typeName { get; set; }//weather
        public int Temperature { get; set; }//weather
        [DataType(DataType.DateTime)]
        public DateTime StartTime { get; set; }
        [DataType(DataType.DateTime)]
        public int EndTime { get; set; }
        [DataType(DataType.DateTime)]
        public int Delay { get; set; }
    }
}
