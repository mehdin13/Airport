using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
    public interface IFlightStatus
    {
        int Insert(AirPortModel.Models.FlightStatus obj);
        ProgressStatus Delete(int id);
        ProgressStatus Update(AirPortModel.Models.FlightStatus obj);
        List<AirPortModel.Models.FlightStatus> ToList();
        AirPortModel.Models.FlightStatus FindById(int id);
    }
}
