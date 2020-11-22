using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
    public interface IFlightStatus
    {
        string Insert(AirPortModel.Models.FlightStatus obj);
        string Delete(int id);
        string Update(AirPortModel.Models.FlightStatus obj);
        List<AirPortModel.Models.FlightStatus> ToList();
        AirPortModel.Models.FlightStatus FindById(int id);
    }
}
