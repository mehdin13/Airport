using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
    public interface IDetailValue
    {
        string Insert(AirPortModel.Models.DetailValue obj);
        string Delete(int Id);
        string Update(AirPortModel.Models.DetailValue obj);
        List<AirPortModel.Models.DetailValue> ToList();
        AirPortModel.Models.DetailValue FindById(int id);
    }
}
