using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.VeiwModel;
using AirPortDataLayer.Crud.InterFace;

namespace AirPortDataLayer.Crud
{
    public class Gallery : IGallery
    {
        private readonly AppDatabaseContext _db;
        public Gallery(AppDatabaseContext db)
        {
            _db = db;
        }
        public int Insert(AirPortModel.Models.Gallery obj)
        {
            try
            {
                obj.DateCreate = DateTime.Now;
                obj.LastUpdate = DateTime.Now;
                obj.IsDelete = false;
                _db.galleries.Add(obj);
                _db.SaveChanges();
                return obj.Id;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public string Delete(int id)
        {
            GalleryImage galleryImage = new GalleryImage(_db);
            try
            {
                var obj = _db.galleries.FirstOrDefault(x => x.Id == id);
                var objgalleryimage = _db.GalleryImages.Where(x => x.GalleryId == id);
                foreach (var item in objgalleryimage)
                {
                    galleryImage.Delete(item.Id);
                }
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.galleries.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public string update(AirPortModel.Models.Gallery obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.galleries.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public List<AirPortModel.Models.Gallery> ToList()
        {
            return _db.galleries.Where(x => x.IsDelete == false).ToList();
        }
        public List<ImageList> ListImage(int id)
        {
            ImageList image = new ImageList();
            List<ImageList> imageLists = new List<ImageList>();
            var gallery = _db.GalleryImages.Where(x => x.GalleryId == id);
            foreach (var item in gallery)
            {
                image.Url = item.Url;
                imageLists.Add(image);
            }
            return imageLists;
        }
        public AirPortModel.Models.Gallery FindById(int id)
        {
            return _db.galleries.FirstOrDefault(x => x.Id == id);
        }
    }
}
