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
        public string Number { get; set; }
        public int AirplainId { get; set; }
        public int AirPortId { get; set; }
        public int FlightStatus { get; set; }
        public int StartAirPort { get; set; }
        public int EndAirPortId { get; set; }
        public int Gate { get; set; }
        public int WeatherId { get; set; }
        public int Temperature { get; set; }
        public string TerminalName { get; set; }//TerminalName

        [DataType(DataType.DateTime)]
        public DateTime StartTime { get; set; }
        [DataType(DataType.DateTime)]
        public int EndTime { get; set; }
        [DataType(DataType.DateTime)]
        public int Delay { get; set; }
    }
}
