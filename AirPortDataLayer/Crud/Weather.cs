using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.InterFace;

namespace AirPortDataLayer.Crud
{
    public class Weather : IWeather
    {
        private readonly AppDatabaseContext _db;
        public Weather(AppDatabaseContext db)
        {
            _db = db;
        }
        public int Insert(AirPortModel.Models.Weather obj)
        {
            try
            {
                obj.DateCreate = DateTime.Now;
                obj.LastUpdate = DateTime.Now;
                obj.IsDelete = false;
                _db.Weather.Add(obj);
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
                var obj = _db.Adresses.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.Adresses.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Delete Successful", Message = "Weather Has been Deleted" };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "Delete Error", Message = "Weather Has been Deleted" };
                return result;
            }
        }
        public ProgressStatus Update(AirPortModel.Models.Weather obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.Weather.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Update Successful", Message = "Weather Has been Update" };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "Update Error", Message = "Weather Has been Update" };
                return result;
            }
        }
        public List<AirPortModel.Models.Weather> ToList()
        {
            return _db.Weather.Where(x => x.IsDelete == false).ToList();
        }
        public AirPortModel.Models.Weather FindById(int id)
        {
            return _db.Weather.FirstOrDefault(x => x.Id == id);
        }
        public AirPortModel.Models.Weather FindByAirportId(int id)
        {
            return _db.Weather.FirstOrDefault(x => x.airportid == id);
        }
    }
}
