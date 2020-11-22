using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
    public interface IDetail
    {
        string Insert(AirPortModel.Models.Detail obj);
        string Delete(int id);
        string Update(AirPortModel.Models.Detail obj);
        List<AirPortModel.Models.Detail> ToList();
        AirPortModel.Models.Detail FindById(int id);
       // List<FeatureValueVeiwModel> FeatureValues(int id);
    }
}
