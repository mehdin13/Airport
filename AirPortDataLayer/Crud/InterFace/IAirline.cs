using System;
using System.Collections.Generic;
using System.Text;
using AirPortDataLayer.Crud.VeiwModel;

namespace AirPortDataLayer.Crud.InterFace
{
    public interface IAirline 
    {
        int Insert(AirPortModel.Models.Airline obj);
        ProgressStatus Delete(int id);
        ProgressStatus Update(AirPortModel.Models.Airline obj);
        List<AirPortModel.Models.Airline> ToList();
        AirPortModel.Models.Airline FindById(int id);

       List<AirPortModel.Models.AirPlane> AirPlaneList(int id);
       List<FeatureValueVeiwModel> airlinedetail(int id);
       List<ImageList> airlineGallery(int id);
    }
}
