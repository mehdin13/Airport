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
        private readonly IAdvertizment _advertizment;
        public AdvertizmentReservationController(IAdvertizment advertizment)
        {
            _advertizment = advertizment;


        }
        [HttpPost]
        [Route("Advertizment")]
        public ProgressStatus Addrequest([FromForm] AdvertizmentReservationViewModel advertizment)
        {
            try
            {

                AirPortModel.Models.Advertizment Requestobj = new AirPortModel.Models.Advertizment();
                if (_advertizment.checkphon(advertizment.Phone).Number.Equals(2))
                {
                    Requestobj.FullName = advertizment.Fullname;
                    Requestobj.Phone = advertizment.Phone;
                    Requestobj.Description = advertizment.Description;
                    return new ProgressStatus { Message = "Request has'been insert Successfuly", Number = 1, Title = "Successful" };
                }
                else
                {
                    return new ProgressStatus { Message = "You allredy sent a Request", Number = 2, Title = "unSuccessful" };
                }
            }
            catch (Exception ex)
            {
                return new ProgressStatus { Message = ex.Message, Number = 0, Title = "" };
            }
        }
    }
}
