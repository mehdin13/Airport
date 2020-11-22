using System;
using System.Collections.Generic;
using System.Text;


namespace AirPortDataLayer.Crud.InterFace
{
    public interface IAddress
    {
        int Insert(AirPortModel.Models.Address Address);
        string Delete(int id);
        string Update(AirPortModel.Models.Address obj);
        List<AirPortModel.Models.Address> ToList();
        AirPortModel.Models.Address FindById(int id);
    }
}
