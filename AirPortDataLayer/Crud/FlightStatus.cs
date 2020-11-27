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
        public int Insert(AirPortModel.Models.FlightStatus obj)
        {
            try
            {
                obj.DateCreate = DateTime.Now;
                obj.LastUpdate = DateTime.Now;
                obj.IsDelete = false;
                _db.flightStatuses.Add(obj);
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
                var obj = _db.flightStatuses.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.flightStatuses.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Delete Successful", Message = "FlightStatus Has been Deleted" };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "Delete Error", Message = "FlightStatus  can't be Deleted" };
                return result;
            }
        }
        public ProgressStatus Update(AirPortModel.Models.FlightStatus obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.flightStatuses.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Update Successful", Message = "FlightStatus  can't be Update" };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "Update Error", Message = "FlightStatus Has been Update" };
                return result;
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
