using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
   public interface IRequest
    {
        int Insert(AirPortModel.Models.Request obj);
        ProgressStatus Delete(int id);
        ProgressStatus Update(AirPortModel.Models.Request obj);
        List<AirPortModel.Models.Request> ToList();
        AirPortModel.Models.Request FindById(int id);
        AirPortModel.Models.Request RequestsHotel();
        AirPortModel.Models.Request RequestsResturant();
        AirPortModel.Models.Request RequestsTour();
        AirPortModel.Models.Request RequestShop();
        AirPortModel.Models.Request RequestsCofeeShop();
        AirPortModel.Models.Request RequestsAnimal();
        AirPortModel.Models.Request RequestsCargo();
        AirPortModel.Models.Request RequestsClearance();
        AirPortModel.Models.Request RequestsAdvertizment();
    }
}
