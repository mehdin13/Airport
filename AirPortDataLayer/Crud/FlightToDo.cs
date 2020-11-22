using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.InterFace;

namespace AirPortDataLayer.Crud
{
    public class FlightToDo : IFlightToDo
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
                obj.DateCreate = DateTime.Now.Date;
                obj.LastUpdate = DateTime.Now.Date;
                _db.FlightToDos.Add(obj);
                _db.SaveChanges();
                return "Successfull";
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
                var obj = _db.FlightToDos.FirstOrDefault(x => x.id == id);
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.FlightToDos.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
                throw;
            }
        }
        public string Update(AirPortModel.Models.FlightToDo obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.FlightToDos.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public List<AirPortModel.Models.FlightToDo> ToList()
        {
            return _db.FlightToDos.Where(x => x.IsDelete == false).ToList();
        }
        public AirPortModel.Models.FlightToDo FindById(int id)
        {
            return _db.FlightToDos.FirstOrDefault(x => x.id == id);
        }
    }
}
