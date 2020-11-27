using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
    public interface ICategory
    {
        int Insert(AirPortModel.Models.Category obj);
        ProgressStatus Delete(int id);
        ProgressStatus Update(AirPortModel.Models.Category obj);
        List<AirPortModel.Models.Category> ToList();
        AirPortModel.Models.Category FindById(int id);
    }
}
