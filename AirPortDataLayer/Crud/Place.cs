﻿using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.VeiwModel;

namespace AirPortDataLayer.Crud
{
    public class Place
    {
        private readonly AppDatabaseContext _db;
        public Place(AppDatabaseContext db)
        {
            _db = db;
        }
        public string Insert(AirPortModel.Models.Place obj)
        {
            try
            {
                _db.places.Add(obj);
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
                Category category = new Category(_db);
                Address address = new Address(_db);
                var obj = _db.places.FirstOrDefault(x => x.Id == id);
                var objaddress = _db.Adresses.Where(x => x.Id == id);
                foreach (var item in objaddress)
                {
                    address.Delete(item.Id);
                }
                var objcategory = _db.categories.Where(x => x.Id == id);
                foreach (var item in objcategory)
                {
                    category.Delete(item.Id);
                }
                obj.IsDelete = true;
                _db.places.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public string Update(AirPortModel.Models.Place obj)
        {
            try
            {
                _db.places.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public List<AirPortModel.Models.Place> ToList()
        {
            return _db.places.Where(x => x.IsDelete == false).ToList();
        }
        public AirPortModel.Models.Place FindById(int id)
        {
            return _db.places.FirstOrDefault(x => x.Id == id);
        }
        public List<ImageList> PlaceGallery(int id)
        {
            Gallery gallery = new Gallery(_db);
            return gallery.ListImage(id).ToList();
        }
        public List<FeatureValueVeiwModel> PlaceDetail(int id)
        {
            Detail detail = new Detail(_db);
            return detail.FeatureValues(id).ToList();
        }
    }
}
