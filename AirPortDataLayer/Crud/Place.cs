using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;

namespace AirPortDataLayer.Crud
{
    public class Place
    {
        private readonly AppDatabaseContext _db;
        public Place(AppDatabaseContext db)
        {
            _db = db;
        }
        public string Insert(AirPortModel.Models.Place obj)
        {
            try
            {
                _db.places.Add(obj);
                _db.SaveChanges();
                return "Successful";
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
                var obj = _db.places.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                _db.places.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public string Update(AirPortModel.Models.Place obj)
        {
            try
            {
                _db.places.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public List<AirPortModel.Models.Place> ToList()
        {
            return _db.places.ToList();
        }
        public AirPortModel.Models.Place FindById(int id)
        {
            return _db.places.FirstOrDefault(x => x.Id == id);
        }
    }
}
