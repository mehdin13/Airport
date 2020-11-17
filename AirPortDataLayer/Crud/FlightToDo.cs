using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;

namespace AirPortDataLayer.Crud
{
    public class FlightToDo
    {
        private readonly AppDatabaseContext _db;
        public FlightToDo(AppDatabaseContext db)
        {
            _db = db;
        }
        public string Insert(AirPortModel.Models.FlightToDo obj)
        {
            try
            {
                _db.FlightToDos.Add(obj);
                _db.SaveChanges();
                return "Successfull";
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
                var obj = _db.FlightToDos.FirstOrDefault(x => x.id == id);
                obj.IsDelete = true;
                _db.FlightToDos.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.ToString();
                throw;
            }
        }
        public string Update(AirPortModel.Models.FlightToDo obj)
        {
            try
            {
                _db.FlightToDos.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public List<AirPortModel.Models.FlightToDo> ToList()
        {
            return _db.FlightToDos.ToList();
        }
        public AirPortModel.Models.FlightToDo FindById(int id)
        {
            return _db.FlightToDos.FirstOrDefault(x => x.id == id);
        }
    }
}
