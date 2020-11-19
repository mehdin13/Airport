using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;

namespace AirPortDataLayer.Crud
{
    public class Gate
    {
        private readonly AppDatabaseContext _db;
        public Gate(AppDatabaseContext db)
        {
            _db = db;
        }
        public string Insert(AirPortModel.Models.Gate obj)
        {
            try
            {
                _db.Gate.Add(obj);
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
                var obj = _db.Gate.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                _db.Gate.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public string Update(AirPortModel.Models.Gate obj)
        {
            try
            {
                _db.Gate.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public List<AirPortModel.Models.Gate> ToList()
        {
            return _db.Gate.Where(x => x.IsDelete == false).ToList();
        }
        public AirPortModel.Models.Gate FindById(int id)
        {
            return _db.Gate.FirstOrDefault(x => x.Id == id);
        }

    }
}
