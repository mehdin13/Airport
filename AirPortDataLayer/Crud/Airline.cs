using System;
using System.Collections.Generic;
using System.Linq;
using AirPortDataLayer.Data;
using AirPortDataLayer.Crud.VeiwModel;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.EntityFrameworkCore;

namespace AirPortDataLayer.Crud
{
    public class Airline : IAirline
    {
        private readonly AppDatabaseContext _db;
        public Airline(AppDatabaseContext db)
        {
            _db = db;
        }
        public int Insert(AirPortModel.Models.Airline obj)
        {
            try
            {
                int id = _db.airlines.OrderByDescending(x => x.DateCreate).Count() + 1;
                obj.Id = id;
                obj.DateCreate = DateTime.Now;
                obj.LastUpdate = DateTime.Now;
                obj.IsDelete = false;
                _db.airlines.Add(obj);
                _db.Database.OpenConnection();
                _db.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Tbl_AirLine ON");
                _db.SaveChanges();
                _db.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Tbl_AirLine OFF");
                return obj.Id;
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                return 0;
            }
            finally
            {
                _db.Database.CloseConnection();
            }
        }
        public ProgressStatus Delete(int id)
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
                var result = new ProgressStatus { Number = 1, Title = "Delete Successful", Message = "AirLine Has been Deleted" };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "Delete Error", Message = "Can't Delete the AirLine" };
                return result;
            }
        }
        public ProgressStatus Update(AirPortModel.Models.Airline obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.airlines.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Updete Successfuly", Message = "AirLine Has been Deleted Successfuly" };
                return result;
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                var result = new ProgressStatus { Number = 0, Title = "Update Error", Message = "Can't Update the AirLine" };
                return result;
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
        public List<AirPortModel.Models.Airline> airlinedetaillists()
        {
            return _db.airlines.Where(x => x.Id.Equals(1) && x.IsDelete == false).ToList();
        }
    }
}
