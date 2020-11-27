using System.Collections.Generic;

namespace AirPortDataLayer.Crud.InterFace
{
   public interface ICustomer
    {
        int Insert(AirPortModel.Models.Customer obj);
        ProgressStatus Delete(int id);
        ProgressStatus Update(AirPortModel.Models.Customer obj);
        List<AirPortModel.Models.Customer> ToList();
        AirPortModel.Models.Customer FindById(int id);
        AirPortModel.Models.Customer FindByEmail(string Email);
        ProgressStatus CheckCstomerMobileExisting(string Mobile);
        ProgressStatus CheckCustomerEmailExisting(string email);
        ProgressStatus CheckLoginInfo(string email, string password);
    }
}
