using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
   public interface IGalleryImage
    {
        int Insert(AirPortModel.Models.GalleryImage obj);
        ProgressStatus Delete(int id);
        ProgressStatus Update(AirPortModel.Models.GalleryImage obj);
        List<AirPortModel.Models.GalleryImage> ToList();
        AirPortModel.Models.GalleryImage FindById(int id);
    }
}
