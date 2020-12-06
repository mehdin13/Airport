using System;
using AirPort.Model;
using AirPort.Model.ViewModel;
using AirPortDataLayer.Crud;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Linq;

namespace AirPort.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdvertizmentReservationController : ControllerBase
    {
        private readonly IRequest _Request;
        private readonly ICustomer _Customer;
        public AdvertizmentReservationController(IRequest request, ICustomer customer)
        {
            _Request = request;
            _Customer = customer;

        }
        public ProgressStatus Addrequest([FromForm] AdvertizmentReservationController advertizment)
        {
            var result = new ProgressStatus();
            try
            {
                //if (_Customer.CheckCustomerEmailExisting(registerViewModel.Email).Number.Equals(2))
                //{
                AirPortModel.Models.Request Requestobj = new AirPortModel.Models.Request();

                Requestobj.Name = advertizment.Name;
                Requestobj.LastName = advertizment.LastName;
                Requestobj.Phone = advertizment.Phone;
                Requestobj.Description = advertizment.description;
                //}
                return result = new ProgressStatus { Message = "", Number = 1, Title = "" };
            }
            catch (Exception ex)
            {
                return result = new ProgressStatus { Message = ex.Message, Number = 1, Title = "" };
                throw;
            }

        }
    }
}
