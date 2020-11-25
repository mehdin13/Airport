using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirPort.Model.ViewModel
{
    public class AdvertizmentReservationViewModel
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        [DataType(DataType.Text)]
        public string Description { get; set; }
    }
}
