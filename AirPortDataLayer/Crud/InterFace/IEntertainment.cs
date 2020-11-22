using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
    public interface IEntertainment
    {
        string Insert(AirPortModel.Models.Entertainment obj);
        string Delete(int id);
        string Update(AirPortModel.Models.Entertainment obj);
        List<AirPortModel.Models.Entertainment> ToList();
        AirPortModel.Models.Entertainment FindById(int id);
       // List<ImageList> EnterTainmenrGallery(int id);
    }
}
