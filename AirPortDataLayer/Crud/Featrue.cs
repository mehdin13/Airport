﻿using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;

namespace AirPortDataLayer.Crud
{
    public class Featrue
    {
        private readonly AppDatabaseContext _db;
        public Featrue(AppDatabaseContext db)
        {
            _db = db;
        }
        public string Insert(AirPortModel.Models.Featrue obj)
        {
            try
            {
                _db.featrues.Add(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public string Delete(int id)
        {
            try
            {
                var obj = _db.featrues.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                _db.featrues.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public string Update (AirPortModel.Models.Featrue obj)
        {
            try
            {
                _db.featrues.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public List<AirPortModel.Models.Featrue> ToList()
        {
            return _db.featrues.ToList();
        }
        public AirPortModel.Models.Featrue FindById(int id)
        {
            return _db.featrues.FirstOrDefault(x => x.Id == id);
        }
    }
}
