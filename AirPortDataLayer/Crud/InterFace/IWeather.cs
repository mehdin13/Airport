using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
    public interface IWeather
    {
        int Insert(AirPortModel.Models.Weather obj);
        ProgressStatus Delete(int id);
        ProgressStatus Update(AirPortModel.Models.Weather obj);
        List<AirPortModel.Models.Weather> ToList();
        AirPortModel.Models.Weather FindById(int id);
    }
}
