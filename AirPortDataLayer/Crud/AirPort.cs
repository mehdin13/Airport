﻿using System;
using System.Collections.Generic;
using System.Text;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.VeiwModel;

namespace AirPortDataLayer.Crud
{
    public class AirPort
    {
        private readonly AppDatabaseContext _db;
        public AirPort(AppDatabaseContext db)
        {
            _db = db;
        }
        public string Insert (AirPortModel.Models.AirPort obj)
        {
            try
            {
                _db.AirPorts.Add(obj);
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
                var obj = _db.AirPorts.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                _db.AirPorts.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }
        }
        public string Update(AirPortModel.Models.AirPort obj)
        {
            try
            {
                _db.AirPorts.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public List<AirPortModel.Models.AirPort> Tolist()
        {
            return _db.AirPorts.ToList();
        }
        public AirPortModel.Models.AirPort FindById(int id)
        {
            return _db.AirPorts.FirstOrDefault(x => x.Id == id);
        }
        public List<FeatureValueVeiwModel> AirportDetail(int id)
        {
            Detail detail = new Detail(_db);
            return detail.FeatureValues(id).ToList();
        }
        public List<ImageList> AirPortGallery(int id)
        {
            Gallery gallery = new Gallery(_db);
            return gallery.ListImage(id).ToList();
        }
    }
}