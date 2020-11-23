using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.VeiwModel;
using AirPortDataLayer.Crud.InterFace;

namespace AirPortDataLayer.Crud
{
    public class Entertainment : IEntertainment
    {
        private readonly AppDatabaseContext _db;
        public Entertainment(AppDatabaseContext db)
        {
            _db = db;
        }
        public int Insert(AirPortModel.Models.Entertainment obj)
        {
            try
            {
                obj.DateCreate = DateTime.Now.Date;
                obj.LastUpdate = DateTime.Now.Date;
                obj.IsDelete = false;
                _db.Entertainment.Add(obj);
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
            try
            {
                var obj = _db.Entertainment.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.Entertainment.Update(obj);
                _db.SaveChanges();
                return "Successfull";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public string Update(AirPortModel.Models.Entertainment obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.Entertainment.Update(obj);
                _db.SaveChanges();
                return "Successful"; 
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public List<AirPortModel.Models.Entertainment> ToList()
        {
            return _db.Entertainment.Where(x => x.IsDelete == false).ToList();
        }
        public AirPortModel.Models.Entertainment FindById(int id)
        {
            return _db.Entertainment.FirstOrDefault(x=>x.Id==id);
        }
        public List<ImageList> EnterTainmenrGallery(int id)
        {
            Gallery gallery = new Gallery(_db);
            return gallery.ListImage(id).ToList();
        }
    }
}
