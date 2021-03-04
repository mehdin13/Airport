using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.VeiwModel;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.EntityFrameworkCore;

namespace AirPortDataLayer.Crud
{
    public class AirPlane : IAirPlane
    {
        private readonly AppDatabaseContext _db;
        public AirPlane(AppDatabaseContext db)
        {
            _db = db;
        }
        public int Insert(AirPortModel.Models.AirPlane obj)
        {
            try
            {
                int id = _db.airPlanes.OrderByDescending(x => x.DateCreate).Count() + 1;
                obj.Id = id;
                obj.DateCreate = DateTime.Now;
                obj.LastUpdate = DateTime.Now;
                obj.IsDelete = false;
                _db.airPlanes.Add(obj);
                _db.Database.OpenConnection();
                _db.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Tbl_AirPlane ON");
                _db.SaveChanges();
                _db.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Tbl_AirPlane OFF");
                return obj.Id;
            }
            catch (Exception ex)
            {
                string ms = ex.Message;
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
                Gallery gallery = new Gallery(_db);
                var obj = _db.airPlanes.FirstOrDefault(x => x.Id == id);
                var objgallery = _db.airPlanes.FirstOrDefault(x => x.Id == id);
                gallery.Delete(objgallery.GalleryId);
                obj.LastUpdate = DateTime.Now.Date;
                obj.IsDelete = true;
                _db.airPlanes.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Delete Successful", Message = "AirPlane Has been Deleted" };
                return result;
            }
            catch (Exception ex)
            {

                var result = new ProgressStatus { Number = 0, Title = "Delete Error", Message = "AirPlane  can't be Deleted" };
                return result;
            }
        }
        public ProgressStatus Update(AirPortModel.Models.AirPlane obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Update Successful", Message = "AirPlane Has been Update" };
                return result;
            }
            catch (Exception ex)
            {

                var result = new ProgressStatus { Number = 0, Title = "Update Error", Message = "AirPlane  can't be Update" };
                return result;
            }
        }
        public List<AirPortModel.Models.AirPlane> ToList()
        {
            return _db.airPlanes.Where(x => !x.IsDelete).ToList();
        }
        public AirPortModel.Models.AirPlane FindById(int id)
        {
            return _db.airPlanes.FirstOrDefault(x => x.Id == id);
        }
        public List<FeatureValueVeiwModel> AirplainDetail(int id)
        {
            Detail detail = new Detail(_db);
            return detail.FeatureValues(id).ToList();
        }
        public List<ImageList> AirplaneGallery(int id)
        {
            Gallery gallery = new Gallery(_db);
            return gallery.ListImage(id).ToList();
        }
        public ProgressStatus CheckairplainCode(string code)
        {
            var result = new ProgressStatus { Number = 1, Title = "CheckairplainCode", Message = "Successful" };
            return result;
        }
        public List<AirPortModel.Models.AirPlane> AirplaneList()
        {
            return _db.airPlanes.Where(x => x.Id.Equals(1) && !x.IsDelete).ToList();
        }
        public List<AirPortModel.Models.AirPlane> AirplaneDetailList()
        {
            return _db.airPlanes.Where(x => x.Id.Equals(2) && !x.IsDelete).ToList();
        }
        public List<AirPortModel.Models.AirPlane> getbybrand(int id)
        {
            return _db.airPlanes.Where(x => x.BrandId == id).ToList();
        }
    }
}
