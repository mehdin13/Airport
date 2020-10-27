using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortModel.Models
{
    class Adress
    {
        public int AdressId { get; set; }
        public string AdressDetail { get; set; }
        public double AdressLocationX { get; set; }
        public double AdressLocationY { get; set; }
        public double AdressLocationR { get; set; }
        public int AdressCityId { get; set; }

    }
}
