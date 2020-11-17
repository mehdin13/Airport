using System;
using System.Collections.Generic;
using System.Text;
using AirPortDataLayer.Data;
using System.Linq;

namespace AirPortDataLayer.Crud
{
    class AirPlane
    {
        private readonly AppDatabaseContext _db;
        public AirPlane(AppDatabaseContext db)
        {
            _db = db;
        }
        public string Insert(AirPortModel.Models.AirPlane obj)
        {
            try
            {
                _db.airPlanes.Add(obj);
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
                var obj = _db.airPlanes.FirstOrDefault(x => x.Id == id);
                obj.IsDelete=true;
                _db.airPlanes.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {

                return ex.ToString();
            }
        }
        public string Update(AirPortModel.Models.AirPlane obj)
        {
            try
            {
                _db.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {

                return ex.ToString();
            }
        }
        public List<AirPortModel.Models.AirPlane> ToList()
        {
            return _db.airPlanes.ToList();
        }
        public AirPortModel.Models.AirPlane FindById(int id)
        {
            return _db.airPlanes.FirstOrDefault(x => x.Id == id);
        }
    }
}
