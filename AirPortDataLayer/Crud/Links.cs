using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;

namespace AirPortDataLayer.Crud
{
    public class Links
    {
        private readonly AppDatabaseContext _db;
        public Links(AppDatabaseContext db)
        {
            _db = db;
        }
        public string Insert(AirPortModel.Models.Links obj)
        {
            try
            {
                _db.Links.Add(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string Delete(int id)
        {
            try
            {
                var obj = _db.Links.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                _db.Links.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string Update(AirPortModel.Models.Links obj)
        {
            try
            {
                _db.Links.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public List<AirPortModel.Models.Links> ToList()
        {
            return _db.Links.ToList();
        }
        public AirPortModel.Models.Links FindById(int id)
        {
            return _db.Links.FirstOrDefault(x => x.Id == id);
        }
    }
}
