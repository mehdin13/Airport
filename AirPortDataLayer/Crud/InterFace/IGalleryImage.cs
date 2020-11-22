using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
   public interface IGalleryImage
    {
        string Insert(AirPortModel.Models.GalleryImage obj);
        string Delete(int id);
        string Update(AirPortModel.Models.GalleryImage obj);
        List<AirPortModel.Models.GalleryImage> ToList();
        AirPortModel.Models.GalleryImage FindById(int id);
    }
}
