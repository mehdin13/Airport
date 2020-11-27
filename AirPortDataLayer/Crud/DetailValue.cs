﻿using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.InterFace;

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
                obj.DateCreate = DateTime.Now;
                obj.LastUpdate = DateTime.Now;
                obj.IsDelete = false;
                _db.detailValues.Add(obj);
                _db.SaveChanges();
                return obj.Id;

            }
            catch (Exception)
            {
                return 0;
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
                obj.LastUpdate = DateTime.Now.Date;
                _db.detailValues.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Update Successful", Message = "DetailValue Has been Update" };
                return result;
            }
            catch (Exception ex)
            {
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
    }
}
