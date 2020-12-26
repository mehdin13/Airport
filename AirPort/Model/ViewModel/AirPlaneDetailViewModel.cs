using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirPortDataLayer.Crud.VeiwModel;

namespace AirPort.Model.ViewModel
{
    public class AirPlaneDetailViewModel
    {
        public int AirPlaneId { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string AirplaneCode { get; set; }
        public int BrandId { get; set; }
        public int GalleryId { get; set; }
        public List<AirPortDataLayer.Crud.VeiwModel.FeatureValueVeiwModel>  Detail { get; set; }
        public int AirLineId { get; set; } 
    }
}
