using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.VeiwModel;
using AirPortDataLayer.Crud.InterFace;

namespace AirPortDataLayer.Crud
{
    public class Place : IPlace
    {
        private readonly AppDatabaseContext _db;
        public Place(AppDatabaseContext db)
        {
            _db = db;
        }
        public int Insert(AirPortModel.Models.Place obj)
        {
            try
            {
                obj.DateCreate = DateTime.Now;
                obj.LastUpdate = DateTime.Now;
                obj.IsDelete = false;
                _db.places.Add(obj);
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
                Category category = new Category(_db);
                Address address = new Address(_db);
                var obj = _db.places.FirstOrDefault(x => x.Id == id);
                var objaddress = _db.Adresses.Where(x => x.Id == id);
                foreach (var item in objaddress)
                {
                    address.Delete(item.Id);
                }
                var objcategory = _db.categories.Where(x => x.Id == id);
                foreach (var item in objcategory)
                {
                    category.Delete(item.Id);
                }
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.places.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Delete Successful", Message = "Place Has been Delete" };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "Delete Error", Message = "Place  can't be Delete" };
                return result;
            }
        }
        public ProgressStatus Update(AirPortModel.Models.Place obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.places.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Update Successful", Message = "Place Has been Update" };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "Update Error", Message = "Place  can't be Update" };
                return result;
            }
        }
        public List<AirPortModel.Models.Place> ToList()
        {
            return _db.places.Where(x => x.IsDelete == false).ToList();
        }
        public AirPortModel.Models.Place FindById(int id)
        {
            return _db.places.FirstOrDefault(x => x.Id == id);
        }
        public List<ImageList> PlaceGallery(int id)
        {
            Gallery gallery = new Gallery(_db);
            return gallery.ListImage(id).ToList();
        }
        public List<FeatureValueVeiwModel> PlaceDetail(int id)
        {
            Detail detail = new Detail(_db);
            return detail.FeatureValues(id).ToList();
        }
        public ProgressStatus checkPlacecategoryid(string Code)
        {
            var result = new ProgressStatus { Number = 1, Title = "palceId", Message = "NotFound" };
            return result;
        }
        public List<AirPortModel.Models.Place> PlaceHotellList()
        {
            return _db.places.Where(x => x.Category.CategoryType.Equals(1) && !x.IsDelete).ToList();
        }
        public List<AirPortModel.Models.Place> PlaceRestaurantid()
        {
            return _db.places.Where(x => x.Category.CategoryType.Equals(2) && !x.IsDelete).ToList();
        }
        public List<AirPortModel.Models.Place> PlaceToureId()
        {
            return _db.places.Where(x => x.Category.CategoryType.Equals(3) && !x.IsDelete).ToList();
        }
        public List<AirPortModel.Models.Place> PlacesShopId()
        {
            return _db.places.Where(x => x.Category.CategoryType.Equals(4) && !x.IsDelete).ToList();
        }
        public List<AirPortModel.Models.Place> PlacesInstitute()
        {
            return _db.places.Where(x => x.Category.CategoryType.Equals(5) && !x.IsDelete).ToList();
        }
        public List<AirPortModel.Models.Place> PlacesCofeeshopId()
        {
            return _db.places.Where(x => x.Category.CategoryType.Equals(6) && !x.IsDelete).ToList();
        }
        public List<AirPortModel.Models.Place> AirportParkingList(int id)
        {
            return _db.places.Where(x => x.Category.CategoryType.Equals(7) && x.AirportId.Equals(id) && !x.IsDelete).ToList();
        }
        public List<AirPortModel.Models.Place> ServicesTypeAnimal()
        {
            return _db.places.Where(x => x.Category.CategoryType.Equals(8) && !x.IsDelete).ToList();
        }
        public List<AirPortModel.Models.Place> ServicesTypeCargo()
        {
            return _db.places.Where(x => x.Category.CategoryType.Equals(9) && !x.IsDelete).ToList();
        }
        public List<AirPortModel.Models.Place> ServicesTypeClearance()
        {
            return _db.places.Where(x => x.Category.CategoryType.Equals(10) && !x.IsDelete).ToList();
        }

    }
}
