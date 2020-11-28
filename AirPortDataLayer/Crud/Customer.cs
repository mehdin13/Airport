using System;
using System.Collections.Generic;
using AirPortDataLayer.Data;
using System.Linq;
using AirPortDataLayer.Crud.InterFace;

namespace AirPortDataLayer.Crud
{
    public class Customer : ICustomer
    {
        public readonly AppDatabaseContext _db;
        public Customer(AppDatabaseContext db)
        {
            _db = db;
        }
        public int Insert(AirPortModel.Models.Customer obj)
        {
            try
            {
                //*****************chek shavad hatma************************************
                AirPortModel.Models.Address Oaddress = new AirPortModel.Models.Address();
                Address address = new Address(_db);
                obj.address = _db.Adresses.FirstOrDefault(x => x.Id == 4);
                //*****************End chek shavad hatma************************************
                //obj.address = null;
                obj.Mobile = null;
                obj.ProfileImage = null;
                obj.Sex = true;
                obj.Isactive = false;
                obj.IsDelete = false;

                obj.DateCreate = DateTime.Now;
                obj.LastUpdate = DateTime.Now;
                _db.customers.Add(obj);
                _db.SaveChanges();
                return obj.Id;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return 0;
            }
        }
        public ProgressStatus Delete(int id)
        {
            try
            {
                FlightToDo flightToDo = new FlightToDo(_db);
                CustomerFlight customerFlight = new CustomerFlight(_db);
                Request request = new Request(_db);
                var obj = _db.customers.FirstOrDefault(x => x.Id == id);
                var objflighttodo = _db.FlightToDos.Where(x => x.id == id);
                foreach (var item in objflighttodo)
                {
                    flightToDo.Delete(item.id);
                }
                var objcustomerFlight = _db.CustomerFlight.Where(x => x.Id == id);
                foreach (var item in objcustomerFlight)
                {
                    customerFlight.Delete(item.Id);
                }
                var objRequest = _db.requests.Where(x => x.Id == id);
                foreach (var item in objRequest)
                {
                    request.Delete(item.Id);
                }
                obj.IsDelete = true;
                obj.LastUpdate = DateTime.Now.Date;
                _db.customers.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "Delete Successful", Message = "Customer Has been Deleted" };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "Delete Error", Message = "Customer  can't be Deleted" };
                return result;
            }
        }
        public ProgressStatus Update(AirPortModel.Models.Customer obj)
        {
            try
            {
                obj.LastUpdate = DateTime.Now.Date;
                _db.customers.Update(obj);
                _db.SaveChanges();
                var result = new ProgressStatus { Number = 1, Title = "update Successful", Message = "Customer Has been Updated" };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "Update Error", Message = "Customer  can't be Updated" };
                return result;
            }
        }
        public List<AirPortModel.Models.Customer> ToList()
        {
            return _db.customers.Where(x => x.IsDelete == false).ToList();
        }
        public AirPortModel.Models.Customer FindById(int id)
        {
            return _db.customers.FirstOrDefault(x => x.Id == id);
        }
        public AirPortModel.Models.Customer FindByEmail(string Email)
        {
            return _db.customers.FirstOrDefault(x => x.Email == Email);
        }
        public ProgressStatus CheckCstomerMobileExisting(string Mobile)
        {
            if (_db.customers.FirstOrDefault(x => x.Mobile == Mobile) != null)
            {
                var result = new ProgressStatus { Number = 1, Title = "phoneNumber Error", Message = "notexist" };
                return result;
            }
            else
            {
                var result = new ProgressStatus { Number = 2, Title = "Successful", Message = "Alredy exist" };
                return result;
            }
        }
        public ProgressStatus CheckCustomerEmailExisting(string email)
        {
            if (_db.customers.FirstOrDefault(X => X.Email == email) != null)
            {
                var result = new ProgressStatus { Number = 1, Title = "successful", Message = "Allredyexist" };
                return result;
            }
            else
            {
                var result = new ProgressStatus { Number = 2, Title = "EmailError", Message = "Notexist" };
                return result;
            }
        }
        public ProgressStatus CheckLoginInfo(string email, string password)
        {
            var User = _db.customers.FirstOrDefault(x => x.Email == email);
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
                var result = new ProgressStatus { Number = 0, Title = "Not Recognized", Message = "Incorrect UserName" };
                return result;
            }
        }
        public ProgressStatus ChengePassWord(string Username, string NewPassword)
        {

            try
            {
                var obj = _db.customers.FirstOrDefault(x => x.Email == Username);
                if (obj != null)
                {
                    obj.LastUpdate = DateTime.Now.Date;
                    obj.Password = NewPassword;
                    _db.customers.Update(obj);
                    _db.SaveChanges();
                    var result = new ProgressStatus { Number = 1, Title = "Password Change", Message = "changed successfuly" };
                    return result;
                }
                else
                {
                    var result = new ProgressStatus { Number = 2, Title = "password Change", Message = "enable to Change" };
                    return result;
                }

            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "Unknown Password Change", Message = "unrecognized input" };
                return result;
            }
        }

    }
}
