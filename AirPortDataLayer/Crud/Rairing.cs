using System;
using System.Collections.Generic;
using System.Linq;
using AirPortDataLayer.Data;
using AirPortDataLayer.Crud.InterFace;

namespace AirPortDataLayer.Crud
{
   public class Rairing : IRaiting
    {
        public readonly AppDatabaseContext _db;
        public Rairing(AppDatabaseContext db)
        {
            _db = db;
        }
        public int Insert(AirPortModel.Models.Raiting obj)
        {
            try
            {
                obj.DateCreate = DateTime.Now;
                obj.LastUpdate = DateTime.Now;
                obj.IsDelete = false;
                _db.raitings.Add(obj);
                _db.SaveChanges();
                return obj.Id;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public ProgressStatus Delete(int id)//delete nemikhad ??
        {

            try
            {
                Rairing advertizment = new Rairing(_db);
                var obj = _db.raitings.FirstOrDefault(x => x.Id == id);
                var objraiting = _db.raitings.Where(x => x.Id == id);
                foreach (var item in objraiting)
                {
                    advertizment.Delete(item.Id);
                }
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.raitings.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Delete Successful", Message = "Raiting Has been Deleted" };
                return result;
            }
            catch (Exception)
            {
                var result = new ProgressStatus { Number = 0, Title = "Delete Error", Message = "Can't Delete the advertizments" };
                return result;
            }
        }

        public ProgressStatus Update(AirPortModel.Models.Raiting obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.raitings.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Updete Successfuly", Message = "Raiting Has been Deleted Successfuly" };
                return result;
            }
            catch (Exception)
            {
                var result = new ProgressStatus { Number = 0, Title = "Update Error", Message = "Can't Update the Raiting" };
                return result;
            }
        }
        public List<AirPortModel.Models.Raiting> ToList()
        {
            return _db.raitings.Where(x => !x.IsDelete).ToList();
        }
        public AirPortModel.Models.Raiting FindById(int id)
        {
            return _db.raitings.FirstOrDefault(x => x.Id == id);
        }
    }
}
