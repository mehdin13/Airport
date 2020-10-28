using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AirPortModel.Models
{
    class Terminal
    {
        [Key]
        public int TerminalId { get; set; }
        [StringLength(50)]
        public string TerminalName { get; set; }
        //Url 
        public string TerminalImage { get; set; }
        //foriegen Key
        public int AirPortId { get; set; }
    }
}
