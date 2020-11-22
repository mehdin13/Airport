using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.InterFace;

namespace AirPortDataLayer.Crud
{
    public class Featrue : IFeatrue
    {
        private readonly AppDatabaseContext _db;
        public Featrue(AppDatabaseContext db)
        {
            _db = db;
        }
        public string Insert(AirPortModel.Models.Featrue obj)
        {
            try
            {
                obj.DateCreate = DateTime.Now.Date;
                obj.LastUpdate = DateTime.Now.Date;
                _db.featrues.Add(obj);
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
                var obj = _db.featrues.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.featrues.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public string Update (AirPortModel.Models.Featrue obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.featrues.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public List<AirPortModel.Models.Featrue> ToList()
        {
            return _db.featrues.Where(x => x.IsDelete == false).ToList();
        }
        public AirPortModel.Models.Featrue FindById(int id)
        {
            return _db.featrues.FirstOrDefault(x => x.Id == id);
        }
    }
}
