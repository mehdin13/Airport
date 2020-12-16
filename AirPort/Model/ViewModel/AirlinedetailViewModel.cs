using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirPort.Model.ViewModel
{
    public class AirlinedetailViewModel
    {
        public string Name { get; set; }
        public string Airline { get; set; }
        public List<AirPortDataLayer.Crud.VeiwModel.FeatureValueVeiwModel> Detail { get; set; }
        public string Logo { get; set; }
        public string Phone { get; set; }
    }
}
