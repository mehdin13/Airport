using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
   public interface IFlightToDo
    {
        int Insert(AirPortModel.Models.FlightToDo obj);
        ProgressStatus Delete(int id);
        ProgressStatus Update(AirPortModel.Models.FlightToDo obj);
        List<AirPortModel.Models.FlightToDo> ToList();
        AirPortModel.Models.FlightToDo FindById(int id);
    }
}
