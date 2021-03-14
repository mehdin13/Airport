using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.InterFace;

namespace AirPortDataLayer.Crud
{
    public class Article : IArticle
    {
        private readonly AppDatabaseContext _db;
        public Article(AppDatabaseContext db)
        {
            _db = db;
        }

        public int Insert(AirPortModel.Models.Article obj)
        {
            try
            {
                obj.DateCreate = DateTime.Now;
                obj.LastUpdate = DateTime.Now;
                obj.IsDelete = false;
                _db.articles.Add(obj);
                _db.SaveChanges();
                return obj.Id;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                return 0;
            }
        }

        public ProgressStatus Delete(int id)
        {
            try
            {
                var obj = _db.articles.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.articles.Update(obj);
                _db.SaveChanges();
                var Result = new ProgressStatus { Number = 1, Title = "Delete Successful", Message = "Article Has been Deleted" };
                return Result;
            }
            catch (Exception ex)
            {
                var Result = new ProgressStatus { Number = 0, Title = "Delete Error", Message = ex.Message };
                return Result;
            }
        }

        public ProgressStatus Update(AirPortModel.Models.Article obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.articles.Update(obj);
                _db.SaveChanges();
                var Result = new ProgressStatus { Number = 1, Title = "Update Successful", Message = "Article Has been Update" };
                return Result;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                var Result = new ProgressStatus { Number = 0, Title = "Update Error", Message = "Article can't be Update" };
                return Result;
            }
        }

        public List<AirPortModel.Models.Article> ToList()
        {
            return _db.articles.Where(x => !x.IsDelete).ToList();
        }
        public AirPortModel.Models.Article FindById(int id)
        {
            return _db.articles.FirstOrDefault(x => x.Id == id);
        }

    }
}
