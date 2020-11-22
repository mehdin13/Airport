using System;
using System.Collections.Generic;
using System.Text;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.VeiwModel;
using AirPortDataLayer.Crud.InterFace;

namespace AirPortDataLayer.Crud
{
    class AirPlane : IAirPlane
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
                obj.DateCreate = DateTime.Now.Date;
                obj.LastUpdate = DateTime.Now.Date;
                obj.IsDelete = false;
                _db.airPlanes.Add(obj);
                _db.SaveChanges();
                return obj.Id;
            }
            catch (Exception ex)
            {

                return 0;
            }
        }
        public string Delete(int id)
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
                return "Successful";
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }
        }
        public string Update(AirPortModel.Models.AirPlane obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }
        }
        public List<AirPortModel.Models.AirPlane> ToList()
        {
            return _db.airPlanes.Where(x => x.IsDelete == false).ToList();
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
            var result = new ProgressStatus { Number = 1, Title = "", Message ="" };
            return result;
        }
    }
}
