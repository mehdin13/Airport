using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
   public interface ICity
    {
        int insert(AirPortModel.Models.City obj);
        ProgressStatus Delete(int id);
        ProgressStatus Update(AirPortModel.Models.City obj);
        List<AirPortModel.Models.City> ToList();
        AirPortModel.Models.City FindById(int id);
        string CheckCityId(int CityId);
    }
}
