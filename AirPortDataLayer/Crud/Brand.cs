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
        public int Insert(AirPortModel.Models.Brand obj)
        {
            try
            {
                obj.DateCreate = DateTime.Now;
                obj.LastUpdate = DateTime.Now;
                obj.IsDelete = false;
                _db.Brand.Add(obj);
                _db.SaveChanges();
                return obj.Id;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public ProgressStatus Delete(int Id)
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
                var result = new ProgressStatus { Number = 1, Title = "Delete Successful", Message = "Brand Has been Deleted" };
                return result;
            }
            catch (Exception ex)
            {

                var result = new ProgressStatus { Number = 0, Title = "Delete Error", Message = "Brand can't be Deleted" };
                return result;
            }
        }
        public ProgressStatus Update(AirPortModel.Models.Brand obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Update Successful", Message = "Brand Has been Update" };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "Update Error", Message = "Brand  can't be Update" };
                return result;
            }
        }
        public List<AirPortModel.Models.Brand> ToList()
        {
            return _db.Brand.Where(x => !x.IsDelete).ToList();
        }
        public AirPortModel.Models.Brand FindById(int id)
        {
            return _db.Brand.FirstOrDefault(x => x.Id == id);
        }
    }
}
