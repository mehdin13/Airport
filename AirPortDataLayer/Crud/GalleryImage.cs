using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.VeiwModel;
using AirPortDataLayer.Crud.InterFace;

namespace AirPortDataLayer.Crud
{
    public class GalleryImage : IGalleryImage
    {
        private readonly AppDatabaseContext _db;
        public GalleryImage(AppDatabaseContext db)
        {
            _db = db;
        }
        public int Insert(AirPortModel.Models.GalleryImage obj)
        {
            try
            {
                obj.DateCreate = DateTime.Now;
                obj.LastUpdate = DateTime.Now;
                obj.IsDelete = false;
                _db.GalleryImages.Add(obj);
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
                var obj = _db.GalleryImages.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.GalleryImages.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Delete Successful", Message = "GalleryImage Has been Deleted" };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "Delete Error", Message = "GalleryImage  can't be Deleted" };
                return result;
            }
        }
        public ProgressStatus Update(AirPortModel.Models.GalleryImage obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.GalleryImages.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Update Successful", Message = "GalleryImage Has been Update" };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "Update Error", Message = "GalleryImage  can't be Update" };
                return result;
            }
        }
        public List<AirPortModel.Models.GalleryImage> ToList()
        {
            return _db.GalleryImages.Where(x => x.IsDelete == false).ToList();
        }
        public AirPortModel.Models.GalleryImage FindById(int id)
        {
            return _db.GalleryImages.FirstOrDefault(x => x.Id == id);
        }
    }
}
