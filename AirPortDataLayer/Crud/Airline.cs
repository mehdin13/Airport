using System;
using System.Collections.Generic;
using System.Linq;
using AirPortDataLayer.Data;
using AirPortDataLayer.Crud.VeiwModel;

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
                obj.DateCreate = DateTime.Now.Date;
                obj.LastUpdate = DateTime.Now.Date;
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
                AirPlane airPlane = new AirPlane(_db);
                var obj = _db.airlines.FirstOrDefault(x => x.Id == id);
                var objairplane = _db.airPlanes.Where(x => x.Id == id);
                foreach (var item in objairplane)
                {
                    airPlane.Delete(item.Id);
                }
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
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
                obj.LastUpdate = DateTime.Now.Date;
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
            return _db.airlines.Where(x => x.IsDelete == false).ToList();
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
        public List<ImageList> airlineGallery(int id)
        {
            Gallery gallery = new Gallery(_db);
            return gallery.ListImage(id).ToList();
        }
    }
}
