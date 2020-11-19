﻿using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.VeiwModel;

namespace AirPortDataLayer.Crud
{
    public class Entertainment
    {
        private readonly AppDatabaseContext _db;
        public Entertainment(AppDatabaseContext db)
        {
            _db = db;
        }
        public string Insert(AirPortModel.Models.Entertainment obj)
        {
            try
            {
                _db.Entertainment.Add(obj);
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
                var obj = _db.Entertainment.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                _db.Entertainment.Update(obj);
                _db.SaveChanges();
                return "Successfull";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public string Update(AirPortModel.Models.Entertainment obj)
        {
            try
            {
                _db.Entertainment.Update(obj);
                _db.SaveChanges();
                return "Successful"; 
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public List<AirPortModel.Models.Entertainment> ToList()
        {
            return _db.Entertainment.ToList();
        }
        public AirPortModel.Models.Entertainment FindById(int id)
        {
            return _db.Entertainment.FirstOrDefault(x=>x.Id==id);
        }
        public List<ImageList> EnterTainmenrGallery(int id)
        {
            Gallery gallery = new Gallery(_db);
            return gallery.ListImage(id).ToList();
        }
    }
}
