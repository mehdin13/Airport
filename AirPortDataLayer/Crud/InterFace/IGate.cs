using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
   public  interface IGate
    {
        int Insert(AirPortModel.Models.Gate obj);
        string Delete(int id);
        string Update(AirPortModel.Models.Gate obj);
        List<AirPortModel.Models.Gate> ToList();
        AirPortModel.Models.Gate FindById(int id);
    }
}
