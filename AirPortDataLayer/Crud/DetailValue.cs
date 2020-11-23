using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.InterFace;

namespace AirPortDataLayer.Crud
{
    public class DetailValue : IDetailValue
    {
        public readonly AppDatabaseContext _db;
        public DetailValue(AppDatabaseContext db)
        {
            _db = db;
        }
        public int Insert(AirPortModel.Models.DetailValue obj)
        {
            try
            {
                obj.DateCreate = DateTime.Now.Date;
                obj.LastUpdate = DateTime.Now.Date;
                obj.IsDelete = false;
                _db.detailValues.Add(obj);
                _db.SaveChanges();
                return obj.Id;

            }
            catch (Exception)
            {
                return 0;
            }
        }
        public string Delete(int Id)
        {
            try
            {
                var obj = _db.detailValues.FirstOrDefault(x => x.Id == Id);
                obj.IsDelete=true;
                obj.LastUpdate = DateTime.Now.Date;
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
                obj.LastUpdate = DateTime.Now.Date;
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
            return _db.detailValues.Where(x => x.IsDelete == false).ToList();
        }
        public AirPortModel.Models.DetailValue FindById(int id)
        {
            return _db.detailValues.FirstOrDefault(x => x.Id == id);
        }
    }
}
