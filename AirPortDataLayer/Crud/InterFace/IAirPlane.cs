using System.Collections.Generic;
using AirPortDataLayer.Crud.VeiwModel;


namespace AirPortDataLayer.Crud.InterFace
{
    public interface IAirPlane
    {
        int Insert(AirPortModel.Models.AirPlane obj);
        ProgressStatus Delete(int id);
        ProgressStatus Update(AirPortModel.Models.AirPlane obj);
        List<AirPortModel.Models.AirPlane> ToList();
        public AirPortModel.Models.AirPlane FindById(int id);
        List<FeatureValueVeiwModel> AirplainDetail(int id);
        List<ImageList> AirplaneGallery(int id);
        ProgressStatus CheckairplainCode(string code);
        List<AirPortModel.Models.AirPlane> AirplaneList();
        List<AirPortModel.Models.AirPlane> AirplaneDetailList();
        List<AirPortModel.Models.AirPlane> getbybrand(int id);
    }
}
