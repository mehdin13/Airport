using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirPort.Model.ViewModel
{
    public class AirlineviewModel
    {
        public string  Name { get; set; }
        public int DetailId { get; set; }
        public string Logo { get; set; }
       // public string Raiting { get; set; }
    }
}
