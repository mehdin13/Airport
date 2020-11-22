using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;

namespace AirPortDataLayer.Crud
{
    public class Customer
    {
        public readonly AppDatabaseContext _db;
        public Customer(AppDatabaseContext db)
        {
            _db = db;
        }
        public string Insert(AirPortModel.Models.Customer obj)
        {
            try
            {
                obj.DateCreate = DateTime.Now.Date;
                obj.LastUpdate = DateTime.Now.Date;
                _db.customers.Add(obj);
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
                FlightToDo flightToDo = new FlightToDo(_db);
                CustomerFlight customerFlight = new CustomerFlight(_db);
                Request request = new Request(_db);
                var obj = _db.customers.FirstOrDefault(x => x.Id == id);
                var objflighttodo = _db.FlightToDos.Where(x => x.id == id);
                foreach (var item in objflighttodo)
                {
                    flightToDo.Delete(item.id);
                }
                var objcustomerFlight = _db.CustomerFlight.Where(x => x.Id == id);
                foreach (var item in objcustomerFlight)
                {
                    customerFlight.Delete(item.Id);
                }
                var objRequest = _db.requests.Where(x => x.Id == id);
                foreach (var item in objRequest)
                {
                    request.Delete(item.Id);
                }
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.customers.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public string Update(AirPortModel.Models.Customer obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.customers.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public List<AirPortModel.Models.Customer> ToList()
        {
            return _db.customers.Where(x => x.IsDelete == false).ToList();
        }
        public AirPortModel.Models.Customer FindById(int id)
        {
           return _db.customers.FirstOrDefault(x => x.Id == id);
        }
    }
}
