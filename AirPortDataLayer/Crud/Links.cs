using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.InterFace;

namespace AirPortDataLayer.Crud
{
    public class Links : ILinks
    {
        private readonly AppDatabaseContext _db;
        public Links(AppDatabaseContext db)
        {
            _db = db;
        }
        public int Insert(AirPortModel.Models.Links obj)
        {
            try
            {
                obj.DateCreate = DateTime.Now.Date;
                obj.LastUpdate = DateTime.Now.Date;
                obj.IsDelete = false;
                _db.Links.Add(obj);
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
                var obj = _db.Links.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.Links.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public string Update(AirPortModel.Models.Links obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.Links.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public List<AirPortModel.Models.Links> ToList()
        {
            return _db.Links.Where(x => x.IsDelete == false).ToList();
        }
        public AirPortModel.Models.Links FindById(int id)
        {
            return _db.Links.FirstOrDefault(x => x.Id == id);
        }
    }
}
