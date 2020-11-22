using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
    public interface IState
    {
        int Insert(AirPortModel.Models.State obj);
        string Delete(int id);
        string Update(AirPortModel.Models.State obj);
        List<AirPortModel.Models.State> ToList();
        AirPortModel.Models.State FindById(int id);
    }
}
