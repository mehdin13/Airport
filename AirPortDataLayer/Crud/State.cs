﻿using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;

namespace AirPortDataLayer.Crud
{
    public class State
    {
        private readonly AppDatabaseContext _db;
        public State(AppDatabaseContext db)
        {
            _db = db;
        }
        public string Insert(AirPortModel.Models.State obj)
        {
            try
            {
                obj.DateCreate = DateTime.Now.Date;
                obj.LastUpdate = DateTime.Now.Date;
                _db.states.Add(obj);
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
                City city = new City(_db);
                var obj = _db.states.FirstOrDefault(x => x.Id == id);
                var objCity = _db.cities.Where(x => x.CityStateId == id);
                foreach (var item in objCity)
                {
                    city.Delete(item.Id);
                }
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.states.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public string Update(AirPortModel.Models.State obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.states.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public List<AirPortModel.Models.State> ToList()
        {
            return _db.states.Where(x => x.IsDelete == false).ToList();
        }
        public AirPortModel.Models.State FindById(int id)
        {
            return _db.states.FirstOrDefault(x => x.Id == id);
        }
    }
}
