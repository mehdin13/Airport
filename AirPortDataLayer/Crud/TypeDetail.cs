using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.VeiwModel;
using AirPortDataLayer.Crud.InterFace;

namespace AirPortDataLayer.Crud
{
    public class TypeDetail : ITypeDetail
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
                obj.DateCreate = DateTime.Now;
                obj.LastUpdate = DateTime.Now;
                obj.IsDelete = false;
                _db.typeDetails.Add(obj);
                _db.SaveChanges();
                return obj.Id;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public ProgressStatus Delete(int id)
        {
            try
            {
                Featrue featrue = new Featrue(_db);
                var obj = _db.typeDetails.FirstOrDefault(x => x.Id == id);
                var objfeature = _db.featrues.Where(x => x.Id == id);
                foreach (var item in objfeature)
                {
                    featrue.Delete(item.Id);
                }
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.typeDetails.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Delete Successful", Message = "TypeDetail Has been Deleted" };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "Delete Error", Message = "TypeDetail  can't be Deleted" };
                return result;
            }
        }
        public ProgressStatus Update(AirPortModel.Models.TypeDetail obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.typeDetails.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Update Successful", Message = "TypeDetail Has been Update" };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "Update Error", Message = "TypeDetail  can't be Update" };
                return result;
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
