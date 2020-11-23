using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.InterFace;

namespace AirPortDataLayer.Crud
{
    class User : IUser
    {
        private readonly AppDatabaseContext _db;
        public User(AppDatabaseContext db)
        {
            _db = db;
        }
        public int Insert(AirPortModel.Models.User obj)
        {
            try
            {
                obj.DateCreate = DateTime.Now.Date;
                obj.LastUpdate = DateTime.Now.Date;
                obj.IsDelete = false;
                _db.users.Add(obj);
                _db.SaveChanges();
                return obj.Id;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public string Delete(int id)
        {
            try
            {
                var obj = _db.users.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.users.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public string Update(AirPortModel.Models.User obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.users.Update(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public List<AirPortModel.Models.User> ToList()
        {
            return _db.users.Where(x => x.IsDelete == false).ToList();
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

        public ProgressStatus CheckUserNameExist(string username)
        {

            if (_db.users.FirstOrDefault(x=>x.Name==username)!=null)
            {
                var result = new ProgressStatus { Number = 1, Title = "User existing Message", Message = "Not exist" };
                return result;
            }
            else
            {
                var result = new ProgressStatus { Number = 3, Title = "User existing Error", Message = "allredy exist" };
                return result;
            }
  
        } 
        public ProgressStatus CheckLoginInfo(string username,string password)
        {
            var User = _db.users.FirstOrDefault(x => x.Name == username);
            if (User != null)
            {
                if (User.Password == password)
                {
                    var result = new ProgressStatus { Number = 10, Title = "Recognized", Message = "correct UserName And Password" };
                    return result;
                }
                else
                {
                    var result = new ProgressStatus { Number = 12, Title = "Not Recognized", Message = "Incorrect Password" };
                    return result;
                }
            }
            else
            {
                var result = new ProgressStatus { Number = 11, Title = "Not Recognized", Message = "Incorrect UserName" };
                return result;
            }
        }

       
    }
}
