using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirPortDataLayer.Crud.InterFace;
using AirPortDataLayer.Crud;
using AirPort.Model.ViewModel;
using System.IO;

namespace AirPort.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class AccountController : ControllerBase
    {

        private readonly ICustomer _Customer;
        public AccountController(ICustomer customerService)
        {
            _Customer = customerService;
        }
        [HttpPost]
        [Route("Register")]
        public ProgressStatus UserRegister(RegisterViewModel registerViewModel)
        {
            var Result = new ProgressStatus();
            try
            {
                if (_Customer.CheckCustomerEmailExisting(registerViewModel.Email).Number == 1)
                {

                    AirPortModel.Models.Customer customerobj = new AirPortModel.Models.Customer();
                    customerobj.Name = registerViewModel.Name;
                    customerobj.LastName = registerViewModel.LastName;
                    customerobj.Email = registerViewModel.Email;
                    customerobj.Password = registerViewModel.Password;
                    _Customer.Insert(customerobj);
                }
                Result = new ProgressStatus { Message = "", Number = 2, Title = "ok" };
                return Result;
            }
            catch (Exception ex)
            {
                Result = new ProgressStatus { Message = ex.Message, Number = 1, Title = "no" };
                return Result;
            }
        }

    }
}
