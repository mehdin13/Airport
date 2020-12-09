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
        public int Insert(AirPortModel.Models.FlightToDo obj)
        {
            try
            {
                obj.DateCreate = DateTime.Now;
                obj.LastUpdate = DateTime.Now;
                obj.IsDelete = false;
                _db.FlightToDos.Add(obj);
                _db.SaveChanges();
                return obj.id;
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
                var obj = _db.FlightToDos.FirstOrDefault(x => x.id == id);
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.FlightToDos.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Delete Successful", Message = "FlightToDo Has been Deleted" };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "Delete Error", Message = ex.Message };
                return result;
            }
        }
        public ProgressStatus Update(AirPortModel.Models.FlightToDo obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.FlightToDos.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Update Successful", Message = "FlightToDo Has been Update" };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "Update Error", Message = ex.Message };
                return result;
            }
        }
        public ProgressStatus Modify(int id, bool isdone)
        {
            AirPortModel.Models.FlightToDo dodo = new AirPortModel.Models.FlightToDo();
            dodo = _db.FlightToDos.FirstOrDefault(x => x.id.Equals(id));
            if (dodo != null)
            {
                dodo.IsDon = isdone;
            }
            try
            {
                _db.FlightToDos.Attach(dodo);
                _db.Entry(dodo).Property(x => x.IsDon).IsModified = true;
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Update Successful", Message = "FlightToDo Has been Update" };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "Update Error", Message = ex.Message };
                return result;
            }
        }
        public List<AirPortModel.Models.FlightToDo> ToList()
        {
            return _db.FlightToDos.Where(x => !x.IsDelete).ToList();
        }
        public AirPortModel.Models.FlightToDo FindById(int id)
        {
            return _db.FlightToDos.FirstOrDefault(x => x.id == id);
        }
        public List<AirPortModel.Models.FlightToDo> FindByCustumerId(int id)
        {
            return _db.FlightToDos.Where(x => x.CustomerId == id).ToList();
        }
    }
}
