using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
   public interface IRequestType
    {
        int Insert(AirPortModel.Models.RequestType obj);
        ProgressStatus Delete(int id);
        ProgressStatus Update(AirPortModel.Models.RequestType obj);
        List<AirPortModel.Models.RequestType> ToList();
        AirPortModel.Models.RequestType FindById(int id);
    }
}
