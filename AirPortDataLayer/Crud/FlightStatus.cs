using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.InterFace;

namespace AirPortDataLayer.Crud
{
    public class FlightStatus : IFlightStatus
    {
        private readonly AppDatabaseContext _db;
        public FlightStatus(AppDatabaseContext db)
        {
            _db = db;
        }
        public string Insert(AirPortModel.Models.FlightStatus obj)
        {
            try
            {
                obj.DateCreate = DateTime.Now.Date;
                obj.LastUpdate = DateTime.Now.Date;
                _db.flightStatuses.Add(obj);
                _db.SaveChanges();
                return "Successfull";
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
                var obj = _db.flightStatuses.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.flightStatuses.Update(obj);
                _db.SaveChanges();
                return "Successfull";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public string Update(AirPortModel.Models.FlightStatus obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.flightStatuses.Update(obj);
                _db.SaveChanges();
                return "Succsessful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public List<AirPortModel.Models.FlightStatus> ToList()
        {
            return _db.flightStatuses.Where(x => x.IsDelete == false).ToList();
        }
        public AirPortModel.Models.FlightStatus FindById(int id)
        {
            return _db.flightStatuses.FirstOrDefault(x => x.Id == id);
        }
    }
}
