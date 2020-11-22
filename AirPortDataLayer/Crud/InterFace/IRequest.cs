using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
   public interface IRequest
    {
        string Insert(AirPortModel.Models.Request obj);
        string Delete(int id);
        string Update(AirPortModel.Models.Request obj);
        List<AirPortModel.Models.Request> ToList();
        AirPortModel.Models.Request FindById(int id);
    }
}
