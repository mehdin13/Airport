﻿using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;

namespace AirPortDataLayer.Crud
{
    public class City
    {
        private readonly AppDatabaseContext _db;
        public City(AppDatabaseContext db)
        {
            _db = db;
        }
        public string insert(AirPortModel.Models.City obj)
        {
            try
            {
                _db.cities.Add(obj);
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
                var obj = _db.cities.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                _db.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public string Update(AirPortModel.Models.City obj)
        {
            try
            {
                _db.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public List<AirPortModel.Models.City> ToList()
        {
            return _db.cities.ToList();
        }
        public AirPortModel.Models.City FindById(int id)
        {
            return _db.cities.FirstOrDefault(x => x.Id == id);
        }

        //************************************
        //new Check City id
        public string CheckCityId(int CityId)
        {
            try
            {
                var obj = _db.cities.FirstOrDefault(i => i.Id == CityId);
                return  obj==null ? "wrong City Id":"Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        //end check City Id
    }
}