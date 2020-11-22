using System.Collections.Generic;

namespace AirPortDataLayer.Crud.InterFace
{
    public interface IUser
    {
        int Insert(AirPortModel.Models.User obj);
        string Delete(int id);
        string Update(AirPortModel.Models.User obj);
        List<AirPortModel.Models.User> ToList();
        AirPortModel.Models.User FindById(int id);
        string CheckUserName(string Username);
        string CheckPassword(string password);
        string CheckuserNameAvailable(string Username);
        ProgressStatus CheckUserNameExist(string username);
        ProgressStatus CheckLoginInfo(string username, string password);
    }
}
