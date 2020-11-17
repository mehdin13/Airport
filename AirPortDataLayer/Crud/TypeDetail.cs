﻿using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;

namespace AirPortDataLayer.Crud
{
  public  class TypeDetail
    {
        private readonly AppDatabaseContext _db;
        public TypeDetail(AppDatabaseContext db)
        {
            _db = db;
        }
        public string Insert(AirPortModel.Models.TypeDetail obj)
        {
            try
            {
                _db.typeDetails.Add(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string Delete(int id)
        {
            try
            {
                var obj = _db.typeDetails.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                _db.typeDetails.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string Update(AirPortModel.Models.TypeDetail obj)
        {
            try
            {
                _db.typeDetails.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public List<AirPortModel.Models.TypeDetail> ToList()
        {
            return _db.typeDetails.ToList();
        }
        public AirPortModel.Models.TypeDetail FindById(int id)
        {
            return _db.typeDetails.FirstOrDefault(x => x.Id == id);
        }
    }
}
