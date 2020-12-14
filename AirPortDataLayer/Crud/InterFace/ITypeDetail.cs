using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
   public interface ITypeDetail
    {
        int Insert(AirPortModel.Models.TypeDetail obj);
        ProgressStatus Delete(int id);
        ProgressStatus Update(AirPortModel.Models.TypeDetail obj);
        List<AirPortModel.Models.TypeDetail> ToList();
        AirPortModel.Models.TypeDetail FindById(int id);
        List<AirPortDataLayer.Crud.VeiwModel.FeatureValueVeiwModel> TypeDetailDetail(int id);
    }
}
