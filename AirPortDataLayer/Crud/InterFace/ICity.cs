using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
   public interface ICity
    {
        string insert(AirPortModel.Models.City obj);
        string Delete(int id);
        string Update(AirPortModel.Models.City obj);
        List<AirPortModel.Models.City> ToList();
        AirPortModel.Models.City FindById(int id);
        //string CheckCityId(int CityId);
    }
}
