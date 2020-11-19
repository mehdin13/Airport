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
                var obj = _db.customers.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
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
        public AirPortModel.Models.Customer FindFindById(int id)
        {
           return _db.customers.FirstOrDefault(x => x.Id == id);
        }
    }
}
