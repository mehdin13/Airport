using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
    public interface IGallery
    {
        string Insert(AirPortModel.Models.Gallery obj);
        string Delete(int id);
        string update(AirPortModel.Models.Gallery obj);
        List<AirPortModel.Models.Gallery> ToList();
        AirPortModel.Models.Gallery FindById(int id);
      //  List<ImageList> ListImage(int id);
    }
}
