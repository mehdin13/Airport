using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.InterFace;

namespace AirPortDataLayer.Crud
{
    public class RequestType : IRequestType
    {
        private readonly AppDatabaseContext _db;
        public RequestType(AppDatabaseContext db)
        {
            _db = db;
        }
        public int Insert(AirPortModel.Models.RequestType obj)
        {
            try
            {
                obj.DateCreate = DateTime.Now.Date;
                obj.LastUpdate = DateTime.Now.Date;
                obj.IsDelete = false;
                _db.requestTypes.Add(obj);
                _db.SaveChanges();
                return obj.Id;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public string Delete(int id)
        {
            try
            { 

                Request request = new Request(_db);
                var obj = _db.requestTypes.FirstOrDefault(x => x.Id == id);
                var objR = _db.requests.Where(x => x.TypeId == id);
                foreach (var item in objR)
                {
                    request.Delete(item.Id);
                }
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
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
                obj.LastUpdate = DateTime.Now.Date;
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
