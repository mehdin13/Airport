using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.VeiwModel;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.EntityFrameworkCore;

namespace AirPortDataLayer.Crud
{
    public class Entertainment : IEntertainment
    {
        private readonly AppDatabaseContext _db;
        public Entertainment(AppDatabaseContext db)
        {
            _db = db;
        }
        public int Insert(AirPortModel.Models.Entertainment obj)
        {
            try
            {
                int id = _db.airPlanes.OrderByDescending(x => x.DateCreate).Count() + 1;
                obj.Id = id;
                obj.DateCreate = DateTime.Now;
                obj.LastUpdate = DateTime.Now;
                obj.IsDelete = false;
                _db.Entertainment.Add(obj);
                _db.Database.OpenConnection();
                _db.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Tbl_Entertainment ON");
                _db.SaveChanges();
                _db.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Tbl_Entertainment OFF");
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
                var obj = _db.Entertainment.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.Entertainment.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Delete Successful", Message = "Entertainment Has been Deleted" };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "Delete Error", Message = "Entertainment  can't be Deleted" };
                _ = ex.Message;
                return result;
            }
        }
        public ProgressStatus Update(AirPortModel.Models.Entertainment obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.Entertainment.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Update Successful", Message = "Entertainment Has been Update" };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "Update Error", Message = "Entertainment  can't be Update" };
                _ = ex.Message;
                return result;
            }
        }
        public List<AirPortModel.Models.Entertainment> ToList()
        {
            return _db.Entertainment.Where(x => !x.IsDelete ).ToList();
        }
        public AirPortModel.Models.Entertainment FindById(int id)
        {
            return _db.Entertainment.FirstOrDefault(x => x.Id == id);
        }
        public List<ImageList> EnterTainmenrGallery(int id)
        {
            Gallery gallery = new Gallery(_db);
            return gallery.ListImage(id).ToList();
        }
        public List<AirPortModel.Models.Entertainment> EntertainmentBookId()
        {
            return _db.Entertainment.Where(x => x.Type.Equals(1) && !x.IsDelete).ToList();
        }
        public List<AirPortModel.Models.Entertainment> entertainmentvideoId()
        {
            return _db.Entertainment.Where(x => x.Type.Equals(2) && !x.IsDelete).ToList();
        }
        public List<AirPortModel.Models.Entertainment> entertainmentmagazineId()
        {
            return _db.Entertainment.Where(x => x.Type.Equals(3) && !x.IsDelete).ToList();
        }
        public List<AirPortModel.Models.Entertainment> entertainmentAviationid()
        {
            return _db.Entertainment.Where(x => x.Type.Equals(4) && !x.IsDelete).ToList();
        }
    }
}
