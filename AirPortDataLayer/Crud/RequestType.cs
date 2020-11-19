using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;

namespace AirPortDataLayer.Crud
{
    public class RequestType
    {
        private readonly AppDatabaseContext _db;
        public RequestType(AppDatabaseContext db)
        {
            _db = db;
        }
        public string Insert(AirPortModel.Models.RequestType obj)
        {
            try
            {
                _db.requestTypes.Add(obj);
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
                var obj = _db.requestTypes.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                _db.requestTypes.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public string Update(AirPortModel.Models.RequestType obj)
        {
            try
            {
                _db.requestTypes.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public List<AirPortModel.Models.RequestType> ToList()
        {
            return _db.requestTypes.Where(x => x.IsDelete == false).ToList();
        }
        public AirPortModel.Models.RequestType FindById(int id)
        {
            return _db.requestTypes.FirstOrDefault(x => x.Id == id);
        }
    }
}
