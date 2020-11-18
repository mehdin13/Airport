using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;

namespace AirPortDataLayer.Crud
{
    public class State
    {
        private readonly AppDatabaseContext _db;
        public State(AppDatabaseContext db)
        {
            _db = db;
        }
        public string Insert(AirPortModel.Models.State obj)
        {
            try
            {
                _db.states.Add(obj);
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
                var obj = _db.states.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                _db.states.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public string Update(AirPortModel.Models.State obj)
        {
            try
            {
                _db.states.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public List<AirPortModel.Models.State> ToList()
        {
            return _db.states.ToList();
        }
        public AirPortModel.Models.State FindById(int id)
        {
            return _db.states.FirstOrDefault(x => x.Id == id);
        }
    }
}
