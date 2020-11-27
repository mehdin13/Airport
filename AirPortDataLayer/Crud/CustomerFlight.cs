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
        public int Insert(AirPortModel.Models.CustomerFlight obj)
        {
            try
            {
                obj.DateCreate = DateTime.Now;
                obj.LastUpdate = DateTime.Now;
                obj.IsDelete = false;
                _db.CustomerFlight.Add(obj);
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
                var obj = _db.CustomerFlight.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.CustomerFlight.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Delete Successful", Message = "CustomerFlight Has been Deleted" };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "Delete Error", Message = "CustomerFlight  can't be Deleted" };
                return result;
            }
        }
        public ProgressStatus Update(AirPortModel.Models.CustomerFlight obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.CustomerFlight.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Update Successful", Message = "CustomerFlight Has been Update" };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "Update Error", Message = "CustomerFlight  can't be Update" };
                return result;
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