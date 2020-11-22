using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
   public interface ICustomer
    {
        string Insert(AirPortModel.Models.Customer obj);
        string Delete(int id);
        string Update(AirPortModel.Models.Customer obj);
        List<AirPortModel.Models.Customer> ToList();
        AirPortModel.Models.Customer FindById(int id);
    }
}
