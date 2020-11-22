using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;

namespace AirPortDataLayer.Crud
{
    class Request
    {
        private readonly AppDatabaseContext _db;
        public Request(AppDatabaseContext db)
        {
            _db = db;
        }
        public string Insert(AirPortModel.Models.Request obj)
        {
            try
            {
                obj.DateCreate = DateTime.Now.Date;
                obj.LastUpdate = DateTime.Now.Date;
                _db.requests.Add(obj);
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

                var obj = _db.requests.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.requests.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public string Update(AirPortModel.Models.Request obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.requests.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public List<AirPortModel.Models.Request> ToList()
        {
            return _db.requests.Where(x => x.IsDelete == false).ToList();
        }
        public AirPortModel.Models.Request FindById(int id)
        {
            return _db.requests.FirstOrDefault(x => x.Id == id);
        }
    }
}
