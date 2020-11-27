using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
    public interface IFeatrue
    {
        int Insert(AirPortModel.Models.Featrue obj);
        ProgressStatus Delete(int id);
        ProgressStatus Update(AirPortModel.Models.Featrue obj);
        List<AirPortModel.Models.Featrue> ToList();
        AirPortModel.Models.Featrue FindById(int id);

    }
}
