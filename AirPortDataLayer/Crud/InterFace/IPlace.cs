using System.Collections.Generic;
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
        List<AirPortModel.Models.Place> PlaceHotellList();
        List<AirPortModel.Models.Place> PlaceRestaurantid();
        List<AirPortModel.Models.Place> PlaceToureId();
        List<AirPortModel.Models.Place> PlacesShopId();
        List<AirPortModel.Models.Place> PlacesCofeeshopId();
        List<AirPortModel.Models.Place> PlacesInstitute();
        List<AirPortModel.Models.Place> AirportParkingList(int id);
        List<AirPortModel.Models.Place> ServicesTypeAnimal();
        List<AirPortModel.Models.Place> ServicesTypeCargo();
        List<AirPortModel.Models.Place> ServicesTypeClearance();
    }
}
