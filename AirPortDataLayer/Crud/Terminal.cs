using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;

namespace AirPortDataLayer.Crud
{
    public class Terminal
    {
        private readonly AppDatabaseContext _db;
        public Terminal(AppDatabaseContext db)
        {
            _db = db;
        }
        public string Insert(AirPortModel.Models.Terminal obj)
        {
            try
            {
                _db.terminals.Add(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string Delete(int id)
        {
            try
            {
                var obj = _db.terminals.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                _db.terminals.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string Update(AirPortModel.Models.Terminal obj)
        {
            try
            {
                _db.terminals.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public List<AirPortModel.Models.Terminal> ToList()
        {
            return _db.terminals.ToList();
        }
        public AirPortModel.Models.Terminal FindById(int id)
        {
            return _db.terminals.FirstOrDefault(x => x.Id == id);
        }
    }
}
