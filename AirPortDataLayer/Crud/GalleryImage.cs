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
                obj.DateCreate = DateTime.Now.Date;
                obj.LastUpdate = DateTime.Now.Date;
                obj.IsDelete = false;
                _db.GalleryImages.Add(obj);
                _db.SaveChanges();
                return obj.Id;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public string Delete(int id)
        {
            try
            {
                var obj = _db.GalleryImages.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.GalleryImages.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public string Update(AirPortModel.Models.GalleryImage obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.GalleryImages.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
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
