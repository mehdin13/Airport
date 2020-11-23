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
                obj.DateCreate = DateTime.Now.Date;
                obj.LastUpdate = DateTime.Now.Date;
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
        public string Delete(int id)
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
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public string Update(AirPortModel.Models.Terminal obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.terminals.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
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
