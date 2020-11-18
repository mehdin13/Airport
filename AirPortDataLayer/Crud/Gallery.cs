using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;

namespace AirPortDataLayer.Crud
{
    public class Gallery
    {
        private readonly AppDatabaseContext _db;
        private Gallery(AppDatabaseContext db)
        {
            _db = db;
        }
        public string Insert(AirPortModel.Models.Gallery obj)
        {
            try
            {
                _db.galleries.Add(obj);
                _db.SaveChanges();
                return "Successfull";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public string Delete(int id)
        {
            try
            {
                var obj = _db.galleries.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
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
            return _db.galleries.ToList();
        }
        public AirPortModel.Models.Gallery FindById(int id)
        {
            return _db.galleries.FirstOrDefault(x => x.Id == id);
        }
    }
}
