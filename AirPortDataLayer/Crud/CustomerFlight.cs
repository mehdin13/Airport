using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.InterFace;

namespace AirPortDataLayer.Crud
{
    public class CustomerFlight : ICustomerFlight
    {
        public readonly AppDatabaseContext _db;
        public CustomerFlight(AppDatabaseContext db)
        {
            _db = db;
        }
        public string Insert(AirPortModel.Models.CustomerFlight obj)
        {
            try
            {
                obj.DateCreate = DateTime.Now.Date;
                obj.LastUpdate = DateTime.Now.Date;
                _db.CustomerFlight.Add(obj);
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
                var obj = _db.CustomerFlight.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.CustomerFlight.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public string Update(AirPortModel.Models.CustomerFlight obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.CustomerFlight.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public List<AirPortModel.Models.CustomerFlight> ToList()
        {
            return _db.CustomerFlight.Where(x => x.IsDelete == false).ToList();
        }
        public AirPortModel.Models.CustomerFlight FindId(int id)
        {
            return _db.CustomerFlight.FirstOrDefault(x => x.Id == id);
        }
    }
}
//check shavad