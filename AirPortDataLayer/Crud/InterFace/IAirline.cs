using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
    public interface IAirline 
    {
        string Insert(AirPortModel.Models.Airline obj);
        string Delete(int id);
        string Update(AirPortModel.Models.Airline obj);
        List<AirPortModel.Models.Airline> ToList();
        AirPortModel.Models.Airline FindById(int id);

      // List<AirPortModel.Models.AirPlane> AirPlaneList(int id);
      // List<FeatureValueVeiwModel> airlinedetail(int id);
      // List<ImageList> airlineGallery(int id);
    }
}
