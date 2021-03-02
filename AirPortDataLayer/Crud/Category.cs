using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.InterFace;

namespace AirPortDataLayer.Crud
{
    public class Category : ICategory
    {
        public readonly AppDatabaseContext _db;
        public Category(AppDatabaseContext db)
        {
            _db = db;
        }
        public int Insert(AirPortModel.Models.Category obj)
        {
            try
            {
                obj.DateCreate = DateTime.Now;
                obj.LastUpdate = DateTime.Now;
                obj.IsDelete = false;
                _db.categories.Add(obj);
                _db.SaveChanges();
                return obj.Id;
            }
            catch (Exception)
            {

                return 0;
            }
        }
        public ProgressStatus Delete(int id)
        {
            try
            {
                var obj = _db.categories.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.categories.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Delete Successful", Message = "Category Has been Deleted" };
                return result;
            }
            catch (Exception ex)
            {

                var result = new ProgressStatus { Number = 0, Title = "Delete Error", Message = "Category  can't be Deleted" };
                return result;
            }
        }
        public ProgressStatus Update(AirPortModel.Models.Category obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.categories.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Delete Successful", Message = "Category Has been Update" };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "Delete Error", Message = "Category  can't be Update" };
                return result;
            }
        }
        public List<AirPortModel.Models.Category> ToList()
        {
            return _db.categories.Where(x => x.IsDelete == false).ToList();
        }
        public AirPortModel.Models.Category FindById(int id)
        {
            return _db.categories.FirstOrDefault(x => x.Id == id);
        }
        //New 
        public AirPortModel.Models.Category FindByCategoryHotell()
        {
            return _db.categories.FirstOrDefault(x => x.CategoryType.Equals(1));
        }
        public AirPortModel.Models.Category FindByCategoryResturant()
        {
            return _db.categories.FirstOrDefault(x => x.CategoryType.Equals(2));
        }
        public AirPortModel.Models.Category FindByCategoryTour()
        {
            return _db.categories.FirstOrDefault(x => x.CategoryType.Equals(3));
        }
        public AirPortModel.Models.Category FindByCategoryShop()
        {
            return _db.categories.FirstOrDefault(x => x.CategoryType.Equals(4));
        }
        public AirPortModel.Models.Category FindByCategoryInstitutee()
        {
            return _db.categories.FirstOrDefault(x => x.CategoryType.Equals(5));
        }
        public AirPortModel.Models.Category FindByCategoryCoffeShop()
        {
            return _db.categories.FirstOrDefault(x => x.CategoryType.Equals(6));
        }
        public AirPortModel.Models.Category FindByCategoryParking()
        {
            return _db.categories.FirstOrDefault(x => x.CategoryType.Equals(7));
        }
        public AirPortModel.Models.Category FindByCategoryAnimal()
        {
            return _db.categories.FirstOrDefault(x => x.CategoryType.Equals(8));
        }
        public AirPortModel.Models.Category FindByCategoryCargo()
        {
            return _db.categories.FirstOrDefault(x => x.CategoryType.Equals(9));
        }
        public AirPortModel.Models.Category FindByCategoryClearance()
        {
            return _db.categories.FirstOrDefault(x => x.CategoryType.Equals(10));
        }
        public AirPortModel.Models.Category FindByCategoryPadcast()
        {
            return _db.categories.FirstOrDefault(x => x.CategoryType.Equals(11));
        }
        public AirPortModel.Models.Category FindByCategoryNews()
        {
            return _db.categories.FirstOrDefault(x => x.CategoryType.Equals(12));
        }
        public AirPortModel.Models.Category FindByCategoryTutorial()
        {
            return _db.categories.FirstOrDefault(x => x.CategoryType.Equals(13));
        }
        public AirPortModel.Models.Category FindByCategoryApplication()
        {
            return _db.categories.FirstOrDefault(x => x.CategoryType.Equals(14));
        }
        public AirPortModel.Models.Category FindByCategoryArticle()
        {
            return _db.categories.FirstOrDefault(x => x.CategoryType.Equals(15));
        }
        public AirPortModel.Models.Category FindByCategoryBook()
        {
            return _db.categories.FirstOrDefault(x => x.CategoryType.Equals(16));
        }
        public AirPortModel.Models.Category FindByCategoryVideo()
        {
            return _db.categories.FirstOrDefault(x => x.CategoryType.Equals(17));
        }
        public AirPortModel.Models.Category FindByCategoryMagazin()
        {
            return _db.categories.FirstOrDefault(x => x.CategoryType.Equals(18));
        }
        public AirPortModel.Models.Category FindByCategoryAviation()
        {
            return _db.categories.FirstOrDefault(x => x.CategoryType.Equals(19));
        }
        //End New
    }
    }

