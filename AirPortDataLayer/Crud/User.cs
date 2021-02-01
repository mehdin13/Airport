using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.InterFace;

namespace AirPortDataLayer.Crud
{
    public class User : IUser
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
                obj.DateCreate = DateTime.Now;
                obj.LastUpdate = DateTime.Now;
                obj.IsDelete = false;
                _db.users.Add(obj);
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
                var obj = _db.users.FirstOrDefault(x => x.Id == id);
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.users.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Delete Successful", Message = "User Has been Deleted" };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "Delete Error", Message = ex.Message };
                return result;
            }
        }
        public ProgressStatus Update(AirPortModel.Models.User obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.users.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Update Successful", Message = "User Has been Update" };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "Update Error", Message = ex.Message };
                return result;
            }
        }
        public List<AirPortModel.Models.User> ToList()
        {
            return _db.users.Where(x => x.IsDelete == false).ToList();
        }
        public AirPortModel.Models.User FindById(int id)
        {
            return _db.users.FirstOrDefault(x => x.Id.Equals(id) && x.IsDelete.Equals(false));
        }
        public AirPortModel.Models.User FindByUserName(string Username)
        {
            return _db.users.FirstOrDefault(x => x.Name.Equals(Username) && x.IsDelete.Equals(false));
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
        public string CheckPassword(string password , string Username)
        {
            try
            {
                var obj = _db.users.FirstOrDefault(p => p.Password.Equals(password)&&p.Name.Equals(Username));
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

            if (_db.users.FirstOrDefault(x => x.Name == username) != null)
            {
                var result = new ProgressStatus { Number = 1, Title = "User existing Message", Message = "Not exist" };
                return result;
            }
            else
            {
                var result = new ProgressStatus { Number = 2, Title = "User existing Error", Message = "allredy exist" };
                return result;
            }

        }
        public ProgressStatus CheckLoginInfo(string username, string password)
        {
            var User = _db.users.FirstOrDefault(x => x.Name == username);
            if (User != null)
            {
                if (User.Password == password)
                {
                    var result = new ProgressStatus { Number = 1, Title = "Recognized", Message = "correct UserName And Password" };
                    return result;
                }
                else
                {
                    var result = new ProgressStatus { Number = 2, Title = "Not Recognized", Message = "Incorrect Password" };
                    return result;
                }
            }
            else
            {
                var result = new ProgressStatus { Number = 3, Title = "Not Recognized", Message = "Incorrect UserName" };
                return result;
            }
        }


    }
}
