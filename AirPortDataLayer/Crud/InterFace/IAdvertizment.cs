using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
    public interface IAdvertizment
    {
        int Insert(AirPortModel.Models.Advertizment obj);
        ProgressStatus Delete(int id);
        ProgressStatus Update(AirPortModel.Models.Advertizment obj);
        List<AirPortModel.Models.Advertizment> ToList();
        AirPortModel.Models.Advertizment FindById(int id);
        public ProgressStatus checkphon(string phone);
    }
}
