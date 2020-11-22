using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
   public interface IRequestType
    {
        string Insert(AirPortModel.Models.RequestType obj);
        string Delete(int id);
        string Update(AirPortModel.Models.RequestType obj);
        List<AirPortModel.Models.RequestType> ToList();
        AirPortModel.Models.RequestType FindById(int id);
    }
}
