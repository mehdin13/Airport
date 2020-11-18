using System;
using System.Collections.Generic;
using System.Linq;
using AirPortDataLayer.Data;

namespace AirPortDataLayer.Crud
{
    public class Airline
    {
        private readonly AppDatabaseContext _db;
        public Airline(AppDatabaseContext db)
        {
            _db = db;
        }
        public string Insert(AirPortModel.Models.Airline obj)
        {
            try
            {
                _db.airlines.Add(obj);
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
                var obj = _db.airlines.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                _db.airlines.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public string Update(AirPortModel.Models.Airline obj)
        {
            try
            {
                _db.airlines.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }
        }
        public List<AirPortModel.Models.Airline> ToList()
        {
            return _db.airlines.ToList();
        }
        public AirPortModel.Models.Airline FindById(int id)
        {
            return _db.airlines.FirstOrDefault(x => x.Id == id);
        }
        //list hava peyma haye airline
        public List<AirPortModel.Models.AirPlane> AirPlaneList(int id)
        {
            return _db.airPlanes.Where(x => x.Id == id).ToList();
        }
        public List<FeatureValueVeiwModel> airlinedetail(int id)
        {
            Detail detail = new Detail(_db);
            return detail.FeatureValues(id).ToList();
        }
    }
}
