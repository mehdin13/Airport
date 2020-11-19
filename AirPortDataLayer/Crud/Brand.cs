using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;

namespace AirPortDataLayer.Crud
{
   public class Brand
    {
        private readonly AppDatabaseContext _db;
        public Brand(AppDatabaseContext db)
        {
            _db = db;
        }
        public string Insert(AirPortModel.Models.Brand obj)
        {
            try
            {
                _db.Brand.Add(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public string Delete(int Id)
        {
            try
            {
                var obj = _db.Brand.FirstOrDefault(x => x.Id == Id);
                obj.IsDelete = true;
                _db.Brand.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }
        }
        public string Update(AirPortModel.Models.Brand obj)
        {
            try
            {
                _db.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public List<AirPortModel.Models.Brand> ToList()
        {
            return _db.Brand.Where(x => x.IsDelete == false).ToList();
        }
        public AirPortModel.Models.Brand FindById(int id)
        {
            return _db.Brand.FirstOrDefault(x => x.Id == id);
        }
    }
}
