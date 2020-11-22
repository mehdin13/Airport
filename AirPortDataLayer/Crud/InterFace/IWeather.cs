using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
    public interface IWeather
    {
        string Insert(AirPortModel.Models.Weather obj);
        string Delete(int id);
        string Update(AirPortModel.Models.Weather obj);
        List<AirPortModel.Models.Weather> ToList();
        AirPortModel.Models.Weather FindById(int id);
    }
}
