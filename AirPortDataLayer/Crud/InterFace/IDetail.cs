using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
    public interface IDetail
    {
        int Insert(AirPortModel.Models.Detail obj);
        ProgressStatus Delete(int id);
        ProgressStatus Update(AirPortModel.Models.Detail obj);
        List<AirPortModel.Models.Detail> ToList();
        AirPortModel.Models.Detail FindById(int id);
        List<AirPortDataLayer.Crud.VeiwModel.FeatureValueVeiwModel> FeatureValues(int id);
    }
}
