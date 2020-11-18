using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;

namespace AirPortDataLayer.Crud
{
    public class Weather
    {
        private readonly AppDatabaseContext _db;
        public Weather(AppDatabaseContext db)
        {
            _db = db;
        }
        public string Insert(AirPortModel.Models.Weather obj)
        {
            try
            {
                _db.Weather.Add(obj);
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
                var obj = _db.Adresses.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                _db.Adresses.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public string Update(AirPortModel.Models.Weather obj)
        {
            try
            {
                _db.Weather.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public List<AirPortModel.Models.Weather> ToList()
        {
            return _db.Weather.ToList();
        }
        public AirPortModel.Models.Weather FindById(int id)
        {
            return _db.Weather.FirstOrDefault(x => x.Id == id);
        }
    }
}
