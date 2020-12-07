using System;
using System.Collections.Generic;
using System.Linq;
using AirPortDataLayer.Data;
using AirPortDataLayer.Crud.VeiwModel;
using AirPortDataLayer.Crud.InterFace;
namespace AirPortDataLayer.Crud
{
    public class Advertizment : IAdvertizment
    {
        public readonly AppDatabaseContext _db;
        public Advertizment(AppDatabaseContext db)
        {
            _db = db;
        }
        public int Insert(AirPortModel.Models.Advertizment obj)
        {
            try
            {
                obj.DateCreate = DateTime.Now;
                obj.LastUpdate = DateTime.Now;
                obj.IsDelete = false;
                _db.advertizments.Add(obj);
                _db.SaveChanges();
                return obj.Id;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public ProgressStatus Delete(int id)
        {

            try
            {
                Advertizment advertizment = new Advertizment(_db);
                var obj = _db.advertizments.FirstOrDefault(x => x.Id == id);
                var objadvertizment = _db.advertizments.Where(x => x.Id == id);
                foreach (var item in objadvertizment)
                {
                    advertizment.Delete(item.Id);
                }
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.advertizments.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Delete Successful", Message = "advertizments Has been Deleted" };
                return result;
            }
            catch (Exception)
            {
                var result = new ProgressStatus { Number = 0, Title = "Delete Error", Message = "Can't Delete the advertizments" };
                return result;
            }
        }
        public ProgressStatus Update(AirPortModel.Models.Advertizment obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.advertizments.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Updete Successfuly", Message = "Advertizment Has been Deleted Successfuly" };
                return result;
            }
            catch (Exception)
            {
                var result = new ProgressStatus { Number = 0, Title = "Update Error", Message = "Can't Update the Advertizment" };
                return result;
            }
        }
        public List<AirPortModel.Models.Advertizment> ToList()
        {
            return _db.advertizments.Where(x => x.IsDelete == false).ToList();
        }
        public AirPortModel.Models.Advertizment FindById(int id)
        {
            return _db.advertizments.FirstOrDefault(x => x.Id == id);
        }
        public ProgressStatus checkphon(string phone)
        {
            if (_db.advertizments.FirstOrDefault(x=>x.Phone==phone)!=null)
            {
                var result = new ProgressStatus { Number = 1, Title = "phoneNumber Error", Message = "alredy a request has been sent" };
                return result;
            }
            else
            {
                var result = new ProgressStatus { Number = 2, Title = "successful request", Message = "request successfuly sent" };
                return result;
            }
        }
    }
}
