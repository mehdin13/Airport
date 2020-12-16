using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirPort.Model.ViewModel
{
    public class AirportDetailViewModel
    {
        public string Name { get; set; }
        public int AirporId { get; set; }
        public string GalleryId { get; set; }
        public string AirportCode { get; set; }
        public string Abbreviation { get; set; }
        public List<AirPortDataLayer.Crud.VeiwModel.FeatureValueVeiwModel> Detail { get; set; }
        public string Phone { get; set; }
        public string AddressId { get; set; }
    }
}
