using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
   public interface ITerminal
    {
        string Insert(AirPortModel.Models.Terminal obj);
        string Delete(int id);
        string Update(AirPortModel.Models.Terminal obj);
        List<AirPortModel.Models.Terminal> ToList();
        AirPortModel.Models.Terminal FindById(int id);
    }
}
