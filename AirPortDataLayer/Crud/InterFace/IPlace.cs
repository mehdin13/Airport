using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
    public interface IPlace
    {
        string Insert(AirPortModel.Models.Place obj);
        string Delete(int id);
        string Update(AirPortModel.Models.Place obj);
        List<AirPortModel.Models.Place> ToList();
        AirPortModel.Models.Place FindById(int id);
        // List<ImageList> PlaceGallery(int id);
        //List<FeatureValueVeiwModel> PlaceDetail(int id);
    }
}
