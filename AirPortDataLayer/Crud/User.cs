using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;

namespace AirPortDataLayer.Crud
{
    class User
    {
        private readonly AppDatabaseContext _db;
        public User(AppDatabaseContext db)
        {
            _db = db;
        }
        public string Insert(AirPortModel.Models.User obj)
        {
            try
            {
                _db.users.Add(obj);
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
                var obj = _db.users.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                _db.users.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string Update(AirPortModel.Models.User obj)
        {
            try
            {
                _db.users.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public List<AirPortModel.Models.User> ToList()
        {
            return _db.users.ToList();
        }
        public AirPortModel.Models.User FindById(int id)
        {
            return _db.users.FirstOrDefault(x => x.Id == id);
        }
        public string CheckUserName(string Username)
        {
            try
            {
                var obj = _db.users.FirstOrDefault(u => u.Name == Username);
                return obj == null ? "WrongUsername" : "CorrectUsername";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public string CheckPassword(string password)
        {
            try
            {
                var obj = _db.users.FirstOrDefault(p => p.Password == password);
                return obj == null ? "WrongPassword" : "CorrectPassword";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public string CheckuserNameAvailable(string Username)
        {
            try
            {
                var obj = _db.users.FirstOrDefault(U => U.Name == Username);
                return obj != null ? "AlreadyExist" : "Successesful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
    }
}
