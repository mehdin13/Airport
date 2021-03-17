using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.InterFace;

namespace AirPortDataLayer.Crud
{
    public class Request : IRequest
    {
        private readonly AppDatabaseContext _db;
        public Request(AppDatabaseContext db)
        {
            _db = db;
        }
        public int Insert(AirPortModel.Models.Request obj)
        {
            try
            {
                obj.DateCreate = DateTime.Now;
                obj.LastUpdate = DateTime.Now;
                obj.IsDelete = false;
                _db.requests.Add(obj);
                _db.SaveChanges();
                return obj.Id;
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                return 0;
            }
        }
        public ProgressStatus Delete(int id)
        {
            try
            {

                var obj = _db.requests.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.requests.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Delete Successful", Message = "Request Has been Deleted" };
                return result;
            }
            catch (Exception )
            {
                var result = new ProgressStatus { Number = 0, Title = "Delete Error", Message = "Request  can't be Deleted" };
                return result;
            }
        }
        public ProgressStatus Update(AirPortModel.Models.Request obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.requests.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Update Successful", Message = "Request Has been Update" };
                return result;
            }
            catch (Exception )
            {
                var result = new ProgressStatus { Number = 0, Title = "Update Error", Message = "Request  can't be Update" };
                return result;
            }
        }
        public List<AirPortModel.Models.Request> ToList()
        {
            return _db.requests.Where(x => !x.IsDelete).ToList();
        }
        public AirPortModel.Models.Request FindById(int id)
        {
            return _db.requests.FirstOrDefault(x => x.Id == id);
        }

        public AirPortModel.Models.Request RequestsHotel()
        {
            return _db.requests.FirstOrDefault(x => x.TypeId.Equals(1));
        }
        public AirPortModel.Models.Request RequestsResturant()
        {
            return _db.requests.FirstOrDefault(x => x.TypeId.Equals(2));
        }
        public AirPortModel.Models.Request RequestsTour()
        {
            return _db.requests.FirstOrDefault(x => x.TypeId.Equals(3));
        }
        public AirPortModel.Models.Request RequestShop()
        {
            return _db.requests.FirstOrDefault(x => x.TypeId.Equals(4));
        }
        public AirPortModel.Models.Request RequestsCofeeShop()
        {
            return _db.requests.FirstOrDefault(x => x.TypeId.Equals(5));
        }
        public AirPortModel.Models.Request RequestsAnimal()
        {
            return _db.requests.FirstOrDefault(x => x.TypeId.Equals(6));
        }
        public AirPortModel.Models.Request RequestsCargo()
        {
            return _db.requests.FirstOrDefault(x => x.TypeId.Equals(7));
        }
        public AirPortModel.Models.Request RequestsClearance()
        {
            return _db.requests.FirstOrDefault(x => x.TypeId.Equals(8));
        }
        public AirPortModel.Models.Request RequestsAdvertizment()
        {
            return _db.requests.FirstOrDefault(x => x.TypeId.Equals(9));
        }
    }
}
