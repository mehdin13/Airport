﻿using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.VeiwModel;


namespace AirPortDataLayer.Crud
{
    public class GalleryImage
    {
        private readonly AppDatabaseContext _db;
        public GalleryImage(AppDatabaseContext db)
        {
            _db = db;
        }
        public string Insert(AirPortModel.Models.GalleryImage obj)
        {
            try
            {
                _db.GalleryImages.Add(obj);
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
                var obj = _db.GalleryImages.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                _db.GalleryImages.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public string Update(AirPortModel.Models.GalleryImage obj)
        {
            try
            {
                _db.GalleryImages.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public List<AirPortModel.Models.GalleryImage> ToList()
        {
            return _db.GalleryImages.ToList();
        }
        public AirPortModel.Models.GalleryImage FindById(int id)
        {
            return _db.GalleryImages.FirstOrDefault(x => x.Id == id);
        }
    }
}