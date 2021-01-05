using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirPort.Model.ViewModel
{
    public class TerminalFlightViewModel
    {
        public string TerminalName { get; set; }
        public string AirLineName { get; set; }
        public string Type { get; set; }//Raft va Bargasht
        public string AirlineIcon { get; set; }
    }
    public class JsonTerminal
    {
        public List<TerminalFlightViewModel> Result { get; set; }
    }
}
