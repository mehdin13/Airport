using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
    public interface ICategory
    {
        int Insert(AirPortModel.Models.Category obj);
        string Delete(int id);
        string Update(AirPortModel.Models.Category obj);
        List<AirPortModel.Models.Category> ToList();
        AirPortModel.Models.Category FindById(int id);
    }
}
