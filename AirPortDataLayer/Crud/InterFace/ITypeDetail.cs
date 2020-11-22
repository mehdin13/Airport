using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
   public interface ITypeDetail
    {
        string Insert(AirPortModel.Models.TypeDetail obj);
        string Delete(int id);
        string Update(AirPortModel.Models.TypeDetail obj);
        List<AirPortModel.Models.TypeDetail> ToList();
        AirPortModel.Models.TypeDetail FindById(int id);
        //List<FeatureValueVeiwModel> TypeDetailDetail(int id);
    }
}
