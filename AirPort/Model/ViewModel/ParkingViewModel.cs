using System.Collections.Generic;


namespace AirPort.Model.ViewModel
{
    public class ParkingViewModel
    {
        public List<AirPortDataLayer.Crud.VeiwModel.FeatureValueVeiwModel> Detail { get; set; }
        public string Cost { get; set; }
        public string Airport { get; set; }
        public double LocationX { get; set; }
        public double LocationY { get; set; }
        public double LocationR { get; set; }
        public string AddressDetail { get; set; }
        public string CityName { get; set; }
        public string StateName { get; set; }
        public string Categori { get; set; }
        public string Capasity { get; set; }
        public string Phone { get; set; } 
    }
}
