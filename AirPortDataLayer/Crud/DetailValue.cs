using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.EntityFrameworkCore;

namespace AirPortDataLayer.Crud
{
    public class DetailValue : IDetailValue
    {
        public readonly AppDatabaseContext _db;
        public DetailValue(AppDatabaseContext db)
        {
            _db = db;
        }
        public int Insert(AirPortModel.Models.DetailValue obj)
        {
            try
            {
                ////
                int id = _db.detailValues.OrderByDescending(x => x.DateCreate).Count() + 1;
                obj.Id = id;
                ////
                obj.DateCreate = DateTime.Now;
                obj.LastUpdate = DateTime.Now;
                obj.IsDelete = false;
                _db.detailValues.Add(obj);
                /////
                _db.Database.OpenConnection();
                _db.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Tbl_DetailValue ON");
                _db.SaveChanges();
                _db.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Tbl_DetailValue OFF");
                ////
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
        public ProgressStatus Delete(int Id)
        {
            try
            {
                var obj = _db.detailValues.FirstOrDefault(x => x.Id == Id);
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.detailValues.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Delete Successful", Message = "DetailValue Has been Deleted" };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "Delete Error", Message = "DetailValue  can't be Deleted" };
                return result;
            }
        }
        public ProgressStatus Update(AirPortModel.Models.DetailValue obj)
        {
            try
            {
                var result = new ProgressStatus { Number = 0, Title = "Update Error", Message = "DetailValue  can't be Update" };
                if (Delete(obj.Id).Number.Equals(1))
                {
                    obj.LastUpdate = DateTime.Now.Date;
                    _db.Attach<AirPortModel.Models.DetailValue>(obj).State = EntityState.Modified;
                    _db.SaveChanges();
                    result = new ProgressStatus { Number = 1, Title = "Update Successful", Message = "DetailValue Has been Update" };
                }
                return result;
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                var result = new ProgressStatus { Number = 0, Title = "Update Error", Message = "DetailValue  can't be Update" };
                return result;
            }
        }
        public List<AirPortModel.Models.DetailValue> ToList()
        {
            return _db.detailValues.Where(x => x.IsDelete == false).ToList();
        }
        public AirPortModel.Models.DetailValue FindById(int id)
        {
            return _db.detailValues.FirstOrDefault(x => x.Id == id);
        }
        public List<AirPortModel.Models.DetailValue> FindByDetailId(int id)
        {
            return _db.detailValues.Where(x => x.DetailId == id).ToList();
        }
    }
}
