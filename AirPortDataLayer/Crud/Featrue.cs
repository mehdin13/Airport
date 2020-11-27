using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.InterFace;

namespace AirPortDataLayer.Crud
{
    public class Featrue : IFeatrue
    {
        private readonly AppDatabaseContext _db;
        public Featrue(AppDatabaseContext db)
        {
            _db = db;
        }
        public int Insert(AirPortModel.Models.Featrue obj)
        {
            try
            {
                obj.DateCreate = DateTime.Now;
                obj.LastUpdate = DateTime.Now;
                obj.IsDelete = false;
                _db.featrues.Add(obj);
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
                var obj = _db.featrues.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.featrues.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Delete Successful", Message = "Featrue Has been Deleted" };
                return result; ;
            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "Delete Error", Message = "Featrue can't be Deleted" };
                return result;
            }
        }
        public ProgressStatus Update(AirPortModel.Models.Featrue obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.featrues.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Update Successful", Message = "Featrue Has been Update" };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "Update Error", Message = "Featrue  can't be Update" };
                return result;
            }
        }
        public List<AirPortModel.Models.Featrue> ToList()
        {
            return _db.featrues.Where(x => x.IsDelete == false).ToList();
        }
        public AirPortModel.Models.Featrue FindById(int id)
        {
            return _db.featrues.FirstOrDefault(x => x.Id == id);
        }
    }
}
