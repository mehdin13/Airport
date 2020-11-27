using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.InterFace;

namespace AirPortDataLayer.Crud
{
    public class Flight : IFlight
    {
        private readonly AppDatabaseContext _db;
        public Flight(AppDatabaseContext db)
        {
            _db = db;
        }
        public int Insert(AirPortModel.Models.Flight obj)
        {
            try
            {
                obj.DateCreate = DateTime.Now;
                obj.LastUpdate = DateTime.Now;
                obj.IsDelete = false;
                _db.flights.Add(obj);
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
                var obj = _db.flights.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.flights.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Delete Successful", Message = "Flight Has been Deleted" };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "Delete Error", Message = "Flight can't be Deleted" };
                return result;
            }
        }
        public ProgressStatus Update(AirPortModel.Models.Flight obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.flights.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Update Successful", Message = "Flight Has been Update" };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "Update Error", Message = "Flight  can't be Update" };
                return result;
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

        public ProgressStatus FlightNumberExist(string Number)
        {
            var Flightnumber = _db.flights.FirstOrDefault(x => x.Number == Number);
            if (Flightnumber != null)
            {
                var result = new ProgressStatus { Number = 1, Title = "Successful", Message = "Not Exist" };
                return result;
            }
            else
            {
                var result = new ProgressStatus { Number = 2, Title = "Faild", Message = "AlredyExist" };
                return result;
            }

        }
    }
}
