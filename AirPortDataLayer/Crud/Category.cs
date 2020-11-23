using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.InterFace;

namespace AirPortDataLayer.Crud
{
    public class Category : ICategory
    {
        public readonly AppDatabaseContext _db;
        public Category(AppDatabaseContext db)
        {
            _db = db;
        }
        public int Insert(AirPortModel.Models.Category obj)
        {
            try
            {
                obj.DateCreate = DateTime.Now.Date;
                obj.LastUpdate = DateTime.Now.Date;
                obj.IsDelete = false;
                _db.categories.Add(obj);
                _db.SaveChanges();
                return obj.Id;
            }
            catch (Exception)
            {

                return 0;
            }
        }
        public string Delete(int id)
        {
            try
            {
                var obj = _db.categories.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
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
                obj.LastUpdate = DateTime.Now.Date;
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
            return _db.categories.Where(x => x.IsDelete == false).ToList();
        }
        public AirPortModel.Models.Category FindById(int id)
        {
            return _db.categories.FirstOrDefault(x => x.Id == id);
        }
    }
}
//Insert Complete baghiash moonde bargashtam mizanam :D
