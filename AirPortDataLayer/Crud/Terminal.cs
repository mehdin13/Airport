using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.InterFace;

namespace AirPortDataLayer.Crud
{
    public class Terminal : ITerminal
    {
        private readonly AppDatabaseContext _db;
        public Terminal(AppDatabaseContext db)
        {
            _db = db;
        }
        public int Insert(AirPortModel.Models.Terminal obj)
        {
            try
            {
                obj.DateCreate = DateTime.Now;
                obj.LastUpdate = DateTime.Now;
                obj.IsDelete = false;
                _db.terminals.Add(obj);
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
                Gate gate = new Gate(_db);
                var obj = _db.terminals.FirstOrDefault(x => x.Id == id);
                var objterminal = _db.Gate.Where(x => x.Id == id);
                foreach (var item in objterminal)
                {
                    gate.Delete(item.Id);
                }
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.terminals.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Delete Successful", Message = "Terminal Has been Deleted" };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "Delete Error", Message = "Terminal  can't be Deleted" };
                return result;
            }
        }
        public ProgressStatus Update(AirPortModel.Models.Terminal obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.terminals.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Update Successful", Message = "Terminal Has been Update" };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "Update Error", Message = "Terminal  can't be Update" };
                return result;
            }
        }
        public List<AirPortModel.Models.Terminal> ToList()
        {
            return _db.terminals.Where(x => x.IsDelete == false).ToList();
        }
        public AirPortModel.Models.Terminal FindById(int id)
        {
            return _db.terminals.FirstOrDefault(x => x.Id == id);
        }
    }
}
