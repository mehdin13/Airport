using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.InterFace;

namespace AirPortDataLayer.Crud
{
    public class Gate : IGate
    {
        private readonly AppDatabaseContext _db;
        public Gate(AppDatabaseContext db)
        {
            _db = db;
        }
        public int Insert(AirPortModel.Models.Gate obj)
        {
            try
            {
                obj.DateCreate = DateTime.Now;
                obj.LastUpdate = DateTime.Now;
                obj.IsDelete = false;
                _db.Gate.Add(obj);
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
                var obj = _db.Gate.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.Gate.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Delete Successful", Message = "Gate Has been Update" };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "Delete Error", Message = "Gate  can't be Update" };
                return result;
            }
        }
        public ProgressStatus Update(AirPortModel.Models.Gate obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.Gate.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Delete Successful", Message = "Gate Has been Update" };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "Delete Error", Message = "Gate can't be Update" };
                return result;
            }
        }
        public List<AirPortModel.Models.Gate> ToList()
        {
            return _db.Gate.Where(x => x.IsDelete == false).ToList();
        }
        public AirPortModel.Models.Gate FindById(int id)
        {
            return _db.Gate.FirstOrDefault(x => x.Id == id);
        }

    }
}
