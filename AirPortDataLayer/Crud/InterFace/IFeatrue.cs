using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
    public interface IFeatrue
    {
        string Insert(AirPortModel.Models.Featrue obj);
        string Delete(int id);
        string Update(AirPortModel.Models.Featrue obj);
        List<AirPortModel.Models.Featrue> ToList();
        AirPortModel.Models.Featrue FindById(int id);

    }
}
