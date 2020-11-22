using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
   public  interface IGate
    {
        string Insert(AirPortModel.Models.Gate obj);
        string Delete(int id);
        string Update(AirPortModel.Models.Gate obj);
        List<AirPortModel.Models.Gate> ToList();
        AirPortModel.Models.Gate FindById(int id);
    }
}
