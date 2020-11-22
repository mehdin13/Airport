using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.VeiwModel;
using AirPortDataLayer.Crud.InterFace;

namespace AirPortDataLayer.Crud
{
  public  class TypeDetail : ITypeDetail
    {
        private readonly AppDatabaseContext _db;
        public TypeDetail(AppDatabaseContext db)
        {
            _db = db;
        }
        public int Insert(AirPortModel.Models.TypeDetail obj)
        {
            try
            {
                obj.DateCreate = DateTime.Now.Date;
                obj.LastUpdate = DateTime.Now.Date;
                obj.IsDelete = false;
                _db.typeDetails.Add(obj);
                _db.SaveChanges();
                return obj.Id;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public string Delete(int id)
        {
            try
            {
                Featrue featrue = new Featrue(_db);
                var obj = _db.typeDetails.FirstOrDefault(x => x.Id == id);
                var objfeature = _db.featrues.Where(x=>x.Id==id);
                foreach (var item in objfeature)
                {
                    featrue.Delete(item.Id);
                }
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.typeDetails.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public string Update(AirPortModel.Models.TypeDetail obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.typeDetails.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public List<AirPortModel.Models.TypeDetail> ToList()
        {
            return _db.typeDetails.Where(x => x.IsDelete == false).ToList();
        }
        public AirPortModel.Models.TypeDetail FindById(int id)
        {
            return _db.typeDetails.FirstOrDefault(x => x.Id == id);
        }
        public List<FeatureValueVeiwModel> TypeDetailDetail(int id)
        {
            Detail detail = new Detail(_db);
            return detail.FeatureValues(id).ToList();
        }
    }
}
