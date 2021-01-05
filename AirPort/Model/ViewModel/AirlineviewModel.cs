using System;
using System.Collections.Generic;

namespace AirPort.Model.ViewModel
{
    public class AirlineviewModel
    {
        public string  Name { get; set; }
        public int DetailId { get; set; }
        public string Logo { get; set; }
       // public string Raiting { get; set; }
    }
    public class JsonAirline
    {
        public List<AirlineviewModel> Result { get; set; }
    }
}
