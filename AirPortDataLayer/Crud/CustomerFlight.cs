﻿using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;

namespace AirPortDataLayer.Crud
{
    public class CustomerFlight
    {
        public readonly AppDatabaseContext _db;
        public CustomerFlight(AppDatabaseContext db)
        {
            _db = db;
        }
        public string Insert(AirPortModel.Models.CustomerFlight obj)
        {
            try
            {
                _db.CustomerFlight.Add(obj);
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
                var obj = _db.CustomerFlight.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                _db.CustomerFlight.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string Update(AirPortModel.Models.CustomerFlight obj)
        {
            try
            {
                _db.CustomerFlight.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public List<AirPortModel.Models.CustomerFlight> ToList()
        {
            return _db.CustomerFlight.ToList();
        }
        public AirPortModel.Models.CustomerFlight FindId(int id)
        {
            return _db.CustomerFlight.FirstOrDefault(x => x.Id == id);
        }
    }
}
//check shavad