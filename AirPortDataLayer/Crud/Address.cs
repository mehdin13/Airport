using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;

namespace AirPortDataLayer.Crud
{
    public class Address
    {
        private readonly AppDatabaseContext _db;
        public Address(AppDatabaseContext db)
        {
            _db = db;
        }
        public string Insert(AirPortModel.Models.Address obj)
        {
            try
            {
                _db.Adresses.Add(obj);
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
                var obj = _db.Adresses.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                _db.Adresses.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string Update(AirPortModel.Models.Address obj)
        {
            try
            {
                _db.Adresses.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public List<AirPortModel.Models.Address> ToList()
        {
            return _db.Adresses.ToList();
        }
        public AirPortModel.Models.Address FindById(int id)
        {
            return _db.Adresses.FirstOrDefault(x => x.Id == id);
        }
    }
}
