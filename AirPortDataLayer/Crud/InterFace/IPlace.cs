using System;
using System.Collections.Generic;
using System.Text;
using AirPortDataLayer.Crud.VeiwModel;
namespace AirPortDataLayer.Crud.InterFace
{
    public interface IPlace
    {
        int Insert(AirPortModel.Models.Place obj);
        ProgressStatus Delete(int id);
        ProgressStatus Update(AirPortModel.Models.Place obj);
        List<AirPortModel.Models.Place> ToList();
        AirPortModel.Models.Place FindById(int id);
        List<ImageList> PlaceGallery(int id);
        List<FeatureValueVeiwModel> PlaceDetail(int id);
        ProgressStatus checkPlacecategoryid(string Code);
    }
}
