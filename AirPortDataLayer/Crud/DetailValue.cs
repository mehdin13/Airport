using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;

namespace AirPortDataLayer.Crud
{
    public class DetailValue
    {
        public readonly AppDatabaseContext _db;
        public DetailValue(AppDatabaseContext db)
        {
            _db = db;
        }
        public string Insert(AirPortModel.Models.DetailValue obj)
        {
            try
            {
                _db.detailValues.Add(obj);
                _db.SaveChanges();
                return "Successfull";

            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public string Delete(int Id)
        {
            try
            {
                var obj = _db.detailValues.FirstOrDefault(x => x.Id == Id);
                obj.IsDelete=true;
                _db.detailValues.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string Update(AirPortModel.Models.DetailValue obj)
        {
            try
            {
                _db.detailValues.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public List<AirPortModel.Models.DetailValue> ToList()
        {
            return _db.detailValues.ToList();
        }
        public AirPortModel.Models.DetailValue FindById(int id)
        {
            return _db.detailValues.FirstOrDefault(x => x.Id == id);
        }
    }
}
