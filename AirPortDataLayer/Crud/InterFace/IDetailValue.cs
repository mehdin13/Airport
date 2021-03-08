using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
    public interface IDetailValue
    {
        int Insert(AirPortModel.Models.DetailValue obj);
        ProgressStatus Delete(int Id);
        ProgressStatus Update(AirPortModel.Models.DetailValue obj);
        List<AirPortModel.Models.DetailValue> ToList();
        AirPortModel.Models.DetailValue FindById(int id);
        List<AirPortModel.Models.DetailValue> FindByDetailId(int id);
    }
}
