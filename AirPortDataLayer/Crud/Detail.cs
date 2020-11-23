﻿using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.InterFace;

namespace AirPortDataLayer.Crud
{
    public class Detail :IDetail
    {
        public readonly AppDatabaseContext _db;
        public Detail(AppDatabaseContext db)
        {
            _db = db;
        }
        public int Insert(AirPortModel.Models.Detail obj)
        {
            try
            {
                obj.DateCreate = DateTime.Now.Date;
                obj.LastUpdate = DateTime.Now.Date;
                obj.IsDelete = false;
                _db.details.Add(obj);
                _db.SaveChanges();
                return obj.Id;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public string Delete(int id)
        {
            try
            {
                DetailValue detailV = new DetailValue(_db);
                var obj = _db.details.FirstOrDefault(x => x.Id == id);
                var objDetail = _db.detailValues.Where(x=>x.Id==id);
                foreach (var item in objDetail)
                {
                    detailV.Delete(item.Id);
                }
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.details.Update(obj);
                _db.SaveChanges();
                return "Successfull";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public string Update(AirPortModel.Models.Detail obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.details.Update(obj);
                _db.SaveChanges();
                return "Successfull";
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }
        }
        public List<AirPortModel.Models.Detail> ToList()
        {
            return _db.details.Where(x => x.IsDelete == false).ToList();
        }
        public AirPortModel.Models.Detail FindById(int id)
        {
            return _db.details.FirstOrDefault(x => x.Id == id);
        }
        public List<FeatureValueVeiwModel> FeatureValues(int id)
        {
            FeatureValueVeiwModel obj = new FeatureValueVeiwModel();
            List<FeatureValueVeiwModel> fvm = new List<FeatureValueVeiwModel>();
            if (_db.details.FirstOrDefault(x => x.Id == id) != null)
            {
                var dv = _db.detailValues.Where(x => x.DetailId == id).ToList();
                foreach (var item in dv)
                {
                    var fe = _db.featrues.FirstOrDefault(x => x.Id == item.FeacherId);
                    obj.name = fe.Name;
                    obj.value = item.Value;
                    fvm.Add(obj);
            
                }
                return fvm;
            }
            else
            {
                return fvm;
            }

        }
    }
}
