using System;
using System.Collections.Generic;
using System.Text;
using AirPortDataLayer.Crud.VeiwModel;

namespace AirPortDataLayer.Crud.InterFace
{
    public interface IGallery
    {
        int Insert(AirPortModel.Models.Gallery obj);
        string Delete(int id);
        string update(AirPortModel.Models.Gallery obj);
        List<AirPortModel.Models.Gallery> ToList();
        AirPortModel.Models.Gallery FindById(int id);
        List<ImageList> ListImage(int id);
    }
}
