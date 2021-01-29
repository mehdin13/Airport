using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirPort.Model.ViewModel
{/// <summary>
/// shamele animal Cargo va Clearance 3 service taze ezafe shode be App
/// </summary>
    public class ServicesViewModel
    {
        //Place
        public string Name { get; set; }
        public string Phone { get; set; }
        //Link
        public string Title { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public int Type { get; set; }
        //address
        public double LocationX { get; set; }
        public double LocationY { get; set; }
        public double LocationR { get; set; }
    }
    public class JsonServices
    {
        public List<ServicesViewModel> Result { get; set; }
    }
}
