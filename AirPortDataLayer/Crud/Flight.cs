using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;


namespace AirPortDataLayer.Crud
{
    public class Flight
    {
        private readonly AppDatabaseContext _db;
        public Flight(AppDatabaseContext db)
        {
            _db = db;
        }
        public string Insert(AirPortModel.Models.Flight obj)
        {
            try
            {
                _db.flights.Add(obj);
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
                var obj = _db.flights.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                _db.flights.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public string Update(AirPortModel.Models.Flight obj)
        {
            try
            {
                _db.flights.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public List<AirPortModel.Models.Flight> ToList()
        {
            return _db.flights.Where(x => x.IsDelete == false).ToList();
        }
        public AirPortModel.Models.Flight FindById(int id)
        {
            return _db.flights.FirstOrDefault(x => x.Id == id);
        }
    }
}
