using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
   public interface IBrand
    {
        int Insert(AirPortModel.Models.Brand obj);
        ProgressStatus Delete(int Id);
        ProgressStatus Update(AirPortModel.Models.Brand obj);
        List<AirPortModel.Models.Brand> ToList();
        AirPortModel.Models.Brand FindById(int id);
    }
}
