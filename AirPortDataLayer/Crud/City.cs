using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.InterFace;

namespace AirPortDataLayer.Crud
{
    public class City : ICity
    {
        private readonly AppDatabaseContext _db;
        public City(AppDatabaseContext db)
        {
            _db = db;
        }
        public int insert(AirPortModel.Models.City obj)
        {
            try
            {
                obj.DateCreate = DateTime.Now;
                obj.LastUpdate = DateTime.Now;
                obj.IsDelete = false;
                _db.cities.Add(obj);
                _db.SaveChanges();
                return obj.Id;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public ProgressStatus Delete(int id)
        {
            try
            {
                var obj = _db.cities.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Delete Successful", Message = "City Has been Deleted" };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "Delete Error", Message = "City  can't be Deleted" };
                return result;
            }
        }
        public ProgressStatus Update(AirPortModel.Models.City obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Update Successful", Message = "City Has been Update" };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "Update Error", Message = "City  can't be Update" };
                return result;
            }
        }
        public List<AirPortModel.Models.City> ToList()
        {
            return _db.cities.Where(x => x.IsDelete == false).ToList();
        }
        public AirPortModel.Models.City FindById(int id)
        {
            return _db.cities.FirstOrDefault(x => x.Id == id);
        }

        //************************************
        //new Check City id
        public string CheckCityId(int CityId)
        {
            try
            {
                var obj = _db.cities.FirstOrDefault(i => i.Id == CityId);
                return obj == null ? "wrong City Id" : "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        //end check City Id
    }
}
