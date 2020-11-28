using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.InterFace;



namespace AirPortDataLayer.Crud
{
    public class Address : IAddress
    {
        private readonly AppDatabaseContext _db;
        public Address(AppDatabaseContext db)
        {
            _db = db;
        }
        public int Insert(AirPortModel.Models.Address obj)
        {
            try
            {
                obj.DateCreate = DateTime.Now;
                obj.LastUpdate = DateTime.Now;
                obj.IsDelete = false;
                _db.Adresses.Add(obj);
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
                var obj = _db.Adresses.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.Adresses.Update(obj);
                _db.SaveChanges();
                var Result = new ProgressStatus { Number = 1, Title = "Delete Successful", Message = "Adresses Has been Deleted" };
                return Result;
            }
            catch (Exception ex)
            {
                var Result = new ProgressStatus { Number = 0, Title = "Delete Error", Message = ex.Message };
                return Result;
            }
        }
        public ProgressStatus Update(AirPortModel.Models.Address obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.Adresses.Update(obj);
                _db.SaveChanges();
                var Result = new ProgressStatus { Number = 1, Title = "Update Successful", Message = "Adresses Has been Update" };
                return Result;
            }
            catch (Exception ex)
            {
                var Result = new ProgressStatus { Number = 0, Title = "Update Error", Message = "Adresses can't be Update" };
                return Result;
            }
        }
        public List<AirPortModel.Models.Address> ToList()
        {
            return _db.Adresses.Where(x => x.IsDelete == false).ToList();
        }
        public AirPortModel.Models.Address FindById(int id)
        {
            return _db.Adresses.FirstOrDefault(x => x.Id == id);
        }
    }
}
//MOsi1.01