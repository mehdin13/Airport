using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;

namespace AirPortDataLayer.Crud
{
    public class Detail
    {
        public readonly AppDatabaseContext _db;
        public Detail(AppDatabaseContext db)
        {
            _db = db;
        }
        public string Insert(AirPortModel.Models.Detail obj)
        {
            try
            {
                _db.details.Add(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string Delete(int id)
        {
            try
            {
                var obj = _db.details.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                _db.details.Update(obj);
                _db.SaveChanges();
                return "Successfull";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string Update(AirPortModel.Models.Detail obj)
        {
            try
            {
                _db.details.Update(obj);
                _db.SaveChanges();
                return "Successfull";
            }
            catch (Exception ex)
            {

                return ex.ToString();
            }
        }
        public List<AirPortModel.Models.Detail> ToList()
        {
            return _db.details.ToList();
        }
        public AirPortModel.Models.Detail FindById(int id)
        {
            return _db.details.FirstOrDefault(x => x.Id == id);
        }
    }
}
