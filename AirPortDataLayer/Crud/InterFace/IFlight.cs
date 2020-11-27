using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
   public interface IFlight
    {
        int Insert(AirPortModel.Models.Flight obj);
        ProgressStatus Delete(int id);
        ProgressStatus Update(AirPortModel.Models.Flight obj);
        List<AirPortModel.Models.Flight> ToList();
        AirPortModel.Models.Flight FindById(int id);
        ProgressStatus FlightNumberExist(string Number);
    }
}
