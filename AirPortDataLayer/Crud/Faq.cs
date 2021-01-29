using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.InterFace;

namespace AirPortDataLayer.Crud
{
    public class Faq : IFaq
    {
        private readonly AppDatabaseContext _db;
        public Faq(AppDatabaseContext db)
        {
            _db = db;
        }

        public int Insert(AirPortModel.Models.Faq obj)
        {
            try
            {
                obj.DateCreate = DateTime.Now;
                obj.LastUpdate = DateTime.Now;
                obj.IsDelete = false;
                _db.faqs.Add(obj);
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
                var obj = _db.faqs.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.faqs.Update(obj);
                _db.SaveChanges();
                var Result = new ProgressStatus { Number = 1, Title = "Delete Successful", Message = "FAQ Has been Deleted" };
                return Result;
            }
            catch (Exception ex)
            {
                var Result = new ProgressStatus { Number = 0, Title = "Delete Error", Message = ex.Message };
                return Result;
            }
        }

        public ProgressStatus Update(AirPortModel.Models.Faq obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.faqs.Update(obj);
                _db.SaveChanges();
                var Result = new ProgressStatus { Number = 1, Title = "Update Successful", Message = "Faq Has been Update" };
                return Result;
            }
            catch (Exception ex)
            {
                var Result = new ProgressStatus { Number = 0, Title = "Update Error", Message = "Faq can't be Update" };
                return Result;
            }
        }

        public List<AirPortModel.Models.Faq> ToList()
        {
            return _db.faqs.Where(x => !x.IsDelete).ToList();
        }
        public AirPortModel.Models.Faq FindById(int id)
        {
            return _db.faqs.FirstOrDefault(x => x.Id == id);
        }
        public List<AirPortModel.Models.Faq> FaqAnimal()
        {
            return _db.faqs.Where(x => x.FaqType.Equals(1) && !x.IsDelete).ToList();
        }
        public List<AirPortModel.Models.Faq> FaqCargo()
        {
            return _db.faqs.Where(x => x.FaqType.Equals(2) && !x.IsDelete).ToList();
        }
        public List<AirPortModel.Models.Faq> FaqClearance()
        {
            return _db.faqs.Where(x => x.FaqType.Equals(3) && !x.IsDelete).ToList();
        }
    }
}
