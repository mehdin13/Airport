using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.VeiwModel;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.EntityFrameworkCore;

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
                int id = _db.GalleryImages.OrderByDescending(x => x.DateCreate).Count() + 1;
                obj.Id = id;
                obj.DateCreate = DateTime.Now;
                obj.LastUpdate = DateTime.Now;
                obj.IsDelete = false;
                _db.GalleryImages.Add(obj);
                _db.Database.OpenConnection();
                _db.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Tbl_GalleryImage ON");
                _db.SaveChanges();
                _db.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Tbl_GalleryImage OFF");
                return obj.Id;
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                return 0;
            }
            finally
            {
                _db.Database.CloseConnection();
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
            catch (Exception)
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
            catch (Exception )
            {
                var result = new ProgressStatus { Number = 0, Title = "Update Error", Message = "GalleryImage  can't be Update" };
                return result;
            }
        }
        public List<AirPortModel.Models.GalleryImage> ToList()
        {
            return _db.GalleryImages.Where(x => !x.IsDelete).ToList();
        }
        public AirPortModel.Models.GalleryImage FindById(int id)
        {
            return _db.GalleryImages.FirstOrDefault(x => x.Id == id);
        }
    }
}
