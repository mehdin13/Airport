using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
   public interface IFlight
    {
        string Insert(AirPortModel.Models.Flight obj);
        string Delete(int id);
        string Update(AirPortModel.Models.Flight obj);
        List<AirPortModel.Models.Flight> ToList();
        AirPortModel.Models.Flight FindById(int id);
    }
}
