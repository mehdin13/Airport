using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
    public interface ICustomerFlight
    {
        int Insert(AirPortModel.Models.CustomerFlight obj);
        ProgressStatus Delete(int id);
        ProgressStatus Update(AirPortModel.Models.CustomerFlight obj);
        List<AirPortModel.Models.CustomerFlight> ToList();
        AirPortModel.Models.CustomerFlight FindId(int id);
    }
}
