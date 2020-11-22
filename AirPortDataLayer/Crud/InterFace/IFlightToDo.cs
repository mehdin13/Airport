using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
   public interface IFlightToDo
    {
        int Insert(AirPortModel.Models.FlightToDo obj);
        string Delete(int id);
        string Update(AirPortModel.Models.FlightToDo obj);
        List<AirPortModel.Models.FlightToDo> ToList();
        AirPortModel.Models.FlightToDo FindById(int id);
    }
}
