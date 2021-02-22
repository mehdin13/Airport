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
        AirPortModel.Models.Category FindByCategoryHotell();
        AirPortModel.Models.Category FindByCategoryResturant();
        AirPortModel.Models.Category FindByCategoryTour();
        AirPortModel.Models.Category FindByCategoryShop();
        AirPortModel.Models.Category FindByCategoryInstitutee();
        AirPortModel.Models.Category FindByCategoryCoffeShop();
        AirPortModel.Models.Category FindByCategoryParking();
        AirPortModel.Models.Category FindByCategoryAnimal();
        AirPortModel.Models.Category FindByCategoryCargo();
        AirPortModel.Models.Category FindByCategoryClearance();
        AirPortModel.Models.Category FindByCategoryPadcast();
        AirPortModel.Models.Category FindByCategoryNews();
        AirPortModel.Models.Category FindByCategoryTutorial();
        AirPortModel.Models.Category FindByCategoryApplication();
        AirPortModel.Models.Category FindByCategoryArticle();
    }
}
