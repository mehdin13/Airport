﻿using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;

namespace AirPortDataLayer.Crud
{
    public class Category
    {
        public readonly AppDatabaseContext _db;
        public Category(AppDatabaseContext db)
        {
            _db = db;
        }
        public string Insert(AirPortModel.Models.Category obj)
        {
            try
            {
                _db.categories.Add(obj);
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
                var obj = _db.categories.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                _db.categories.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }
        }
        public string Update(AirPortModel.Models.Category obj)
        {
            try
            {
                _db.categories.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public List<AirPortModel.Models.Category> ToList()
        {
            return _db.categories.ToList();
        }
        public AirPortModel.Models.Category FindById(int id)
        {
            return _db.categories.FirstOrDefault(x => x.Id == id);
        }
    }
}
//Insert Complete baghiash moonde bargashtam mizanam :D