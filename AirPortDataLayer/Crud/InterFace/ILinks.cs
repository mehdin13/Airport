using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
   public interface ILinks
    {
        int Insert(AirPortModel.Models.Links obj);
        ProgressStatus Delete(int id);
        ProgressStatus Update(AirPortModel.Models.Links obj);
        List<AirPortModel.Models.Links> ToList();
        AirPortModel.Models.Links FindById(int id);
        public List<AirPortModel.Models.Links> Listlinks();
        public List<AirPortModel.Models.Links> LinkType();
    }
}
