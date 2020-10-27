using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortModel.Models
{
    class Terminal
    {
        public int TerminalId { get; set; }
        public string TerminalName { get; set; }
        public string TerminalImage { get; set; }
        public int AirPortId { get; set; }
    }
}
