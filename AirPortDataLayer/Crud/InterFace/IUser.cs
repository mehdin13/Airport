using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
    public interface IUser
    {
        string Insert(AirPortModel.Models.User obj);
        string Delete(int id);
        string Update(AirPortModel.Models.User obj);
        List<AirPortModel.Models.User> ToList();
        AirPortModel.Models.User FindById(int id);
      //string CheckUserName(string Username);
      //string CheckPassword(string password);
      //string CheckuserNameAvailable(string Username);
    }
}
