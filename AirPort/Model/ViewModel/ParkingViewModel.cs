using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirPort.Model.ViewModel
{
    public class ParkingViewModel
    {
        public string Detail { get; set; }
        public string Cost { get; set; }
        public string Airport { get; set; }
        public double LocationX { get; set; }
        public double LocationY { get; set; }
        public double LocationR { get; set; }
        public int AddressDetail { get; set; }
        public string CityName { get; set; }
        public string StateName { get; set; }
        public string Categori { get; set; }
    }
}
