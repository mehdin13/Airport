using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.InterFace;

namespace AirPortDataLayer.Crud
{
    public class Links : ILinks
    {
        private readonly AppDatabaseContext _db;
        public Links(AppDatabaseContext db)
        {
            _db = db;
        }
        public int Insert(AirPortModel.Models.Links obj)
        {
            try
            {
                obj.DateCreate = DateTime.Now;
                obj.LastUpdate = DateTime.Now;
                obj.IsDelete = false;
                _db.Links.Add(obj);
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
                var obj = _db.Links.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.Links.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Delete Successful", Message = "Links Has been Deleted" };
                return result;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                var result = new ProgressStatus { Number = 0, Title = "Delete Error", Message = "Links  can't be Deleted" };
                return result;
            }
        }
        public ProgressStatus Update(AirPortModel.Models.Links obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.Links.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Update Successful", Message = "Links Has been Update" };
                return result;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                var result = new ProgressStatus { Number = 0, Title = "Update Error", Message = "Links can't be Update" };
                return result;
            }
        }
        public List<AirPortModel.Models.Links> ToList()
        {
            return _db.Links.Where(x => !x.IsDelete).ToList();
        }
        public AirPortModel.Models.Links FindById(int id)
        {
            return _db.Links.FirstOrDefault(x => x.Id == id);
        }
        public List<AirPortModel.Models.Links> LinkType()
        {
            return _db.Links.Where(x => x.Category.CategoryType.Equals(2) && !x.IsDelete).ToList();
        }
        //new entery has to add to our InterFace to debuge the errors and useing of them
        public List<AirPortModel.Models.Links> PadkastCategory()
        {
            return _db.Links.Where(x => x.Category.CategoryType.Equals(11)! && x.IsDelete).ToList();
        }
        public List<AirPortModel.Models.Links> NewsCategory()
        {
            return _db.Links.Where(x => x.Category.CategoryType.Equals(12)! && x.IsDelete).ToList();
        }
        public List<AirPortModel.Models.Links> TutorialCategory()
        {
            return _db.Links.Where(x => x.Category.CategoryType.Equals(13)! && x.IsDelete).ToList();
        }
        public List<AirPortModel.Models.Links> ApplicationCategory()
        {
            return _db.Links.Where(x => x.Category.CategoryType.Equals(14)! && x.IsDelete).ToList();
        }
        public List<AirPortModel.Models.Links> ArticleCategory()
        {
            return _db.Links.Where(x => x.Category.CategoryType.Equals(15) && !x.IsDelete).ToList();
        }
        public List<AirPortModel.Models.Links> entertainmentsBook()
        {
            return _db.Links.Where(x => x.Category.CategoryType.Equals(16) && !x.IsDelete).ToList();
        }
        public List<AirPortModel.Models.Links> entertainmentVideo()
        {
            return _db.Links.Where(x => x.Category.CategoryType.Equals(17) && !x.IsDelete).ToList();
        }
        public List<AirPortModel.Models.Links> entertainmentMagazin()
        {
            return _db.Links.Where(x => x.Category.CategoryType.Equals(18) && !x.IsDelete).ToList();
        }
        public List<AirPortModel.Models.Links> entertainmentAviation()
        {
            return _db.Links.Where(x => x.Category.CategoryType.Equals(19) && !x.IsDelete).ToList();
        }
    }
}
