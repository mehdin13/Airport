using System;
using System.Collections.Generic;
using System.Text;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.VeiwModel;
using AirPortDataLayer.Crud.InterFace;


namespace AirPortDataLayer.Crud
{
    public class AirPort :IAirPort
    {
        private readonly AppDatabaseContext _db;
        public AirPort(AppDatabaseContext db)
        {
            _db = db;
        }
        public string Insert (AirPortModel.Models.AirPort obj)
        {
            try
            {
                obj.DateCreate = DateTime.Now.Date;
                obj.LastUpdate = DateTime.Now.Date;
                _db.AirPorts.Add(obj);
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
                Weather weather = new Weather(_db);
                Gallery gallery = new Gallery(_db);
                Address address = new Address(_db);
                var obj = _db.AirPorts.FirstOrDefault(x => x.Id == id);
                var objWeather = _db.Weather.Where(x=>x.Id==id);
                foreach (var item in objWeather)
                {
                    weather.Delete(item.Id);
                }
                var objgallery = _db.galleries.Where(x => x.Id == id);
                foreach (var item in objgallery)
                {
                    gallery.Delete(item.Id);
                }
                var objaddres = _db.Adresses.Where(x => x.Id == id);
                foreach (var item in objaddres)
                {
                    address.Delete(item.Id);
                }
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.AirPorts.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }
        }
        public string Update(AirPortModel.Models.AirPort obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.AirPorts.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public List<AirPortModel.Models.AirPort> Tolist()
        {
            return _db.AirPorts.Where(x => x.IsDelete == false).ToList();
        }
        public AirPortModel.Models.AirPort FindById(int id)
        {
            return _db.AirPorts.FirstOrDefault(x => x.Id == id);
        }
        public List<FeatureValueVeiwModel> AirportDetail(int id)
        {
            Detail detail = new Detail(_db);
            return detail.FeatureValues(id).ToList();
        }
        public List<ImageList> AirPortGallery(int id)
        {
            Gallery gallery = new Gallery(_db);
            return gallery.ListImage(id).ToList();
        }
        public ProgressStatus CheckAirportCode(string code)
        {
            var result = new ProgressStatus { Number = 1, Title = "NotFound", Message = "یافت نشد" };
            return result;
        }
    }
}
