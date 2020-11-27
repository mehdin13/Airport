using System;
using System.Collections.Generic;
using System.Text;
using AirPortDataLayer.Crud.VeiwModel;


namespace AirPortDataLayer.Crud.InterFace
{
   public interface IAirPlane
    {
        int Insert(AirPortModel.Models.AirPlane obj);
        ProgressStatus Delete(int id);
        ProgressStatus Update(AirPortModel.Models.AirPlane obj);
        List<AirPortModel.Models.AirPlane> ToList();
        AirPortModel.Models.AirPlane FindById(int id);

       public List<FeatureValueVeiwModel> AirplainDetail(int id);
       List<ImageList> AirplaneGallery(int id);
        ProgressStatus CheckairplainCode(string code);
    }
}
