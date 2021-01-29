using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
    public interface ICategory
    {
        int Insert(AirPortModel.Models.Category obj);
        ProgressStatus Delete(int id);
        ProgressStatus Update(AirPortModel.Models.Category obj);
        List<AirPortModel.Models.Category> ToList();
        AirPortModel.Models.Category FindById(int id);
        public AirPortModel.Models.Category FindByCategoryPlaceTypeId();
        public AirPortModel.Models.Category FindByCategoryLinkTypeId();
        public AirPortModel.Models.Category FindbyCategoryAnimal();
        public AirPortModel.Models.Category FindByCategoryCargo();
        public AirPortModel.Models.Category FindByCategoryClearance();
    }
}
