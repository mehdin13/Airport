using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.InterFace;

namespace AirPortDataLayer.Crud
{
   public class Brand :IBrand
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
                obj.DateCreate = DateTime.Now.Date;
                obj.LastUpdate = DateTime.Now.Date;
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
                AirPlane airPlane = new AirPlane(_db);
                var obj = _db.Brand.FirstOrDefault(x => x.Id == Id);
                var objairplane = _db.airPlanes.Where(x => x.Id == Id);
                foreach (var item in objairplane)
                {
                    airPlane.Delete(item.Id);
                }
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
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
                obj.LastUpdate = DateTime.Now.Date;
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
