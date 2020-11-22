using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
   public interface ILinks
    {
        string Insert(AirPortModel.Models.Links obj);
        string Delete(int id);
        string Update(AirPortModel.Models.Links obj);
        List<AirPortModel.Models.Links> ToList();
        AirPortModel.Models.Links FindById(int id);
    }
}
