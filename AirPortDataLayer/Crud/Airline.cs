using System;
using System.Collections.Generic;
using System.Linq;
using AirPortDataLayer.Data;

namespace AirPortDataLayer.Crud
{
    public class Airline
    {
        private readonly AppDatabaseContext _db;
        public Airline(AppDatabaseContext db)
        {
            _db = db;
        }
        public string Insert(AirPortModel.Models.Airline obj)
        {
            try
            {
                _db.airlines.Add(obj);
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
                var obj = _db.airlines.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                _db.airlines.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string Update(AirPortModel.Models.Airline obj)
        {
            try
            {
                _db.airlines.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {

                return ex.ToString();
            }
        }
        public List<AirPortModel.Models.Airline> ToList()
        {
            return _db.airlines.ToList();
        }
        public AirPortModel.Models.Airline FindById(int id)
        {
            return _db.airlines.FirstOrDefault(x => x.Id == id);
        }
    }
}
