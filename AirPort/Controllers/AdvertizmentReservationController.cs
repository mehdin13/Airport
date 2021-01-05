using System;
using AirPort.Model.ViewModel;
using AirPortDataLayer.Crud;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Mvc;

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
            var result = new ProgressStatus();
            try
            {
                AirPortModel.Models.Advertizment Requestobj = new AirPortModel.Models.Advertizment();
                if (_advertizment.checkphon(advertizment.Phone).Number.Equals(2))
                {
                    Requestobj.FullName = advertizment.Fullname;
                    Requestobj.Phone = advertizment.Phone;
                    Requestobj.Description = advertizment.Description;
                    _advertizment.Insert(Requestobj);
                    result = new ProgressStatus { Message = "Request has'been insert Successfuly", Number = 1, Title = "Successful" };
                    return result;
                }
                else
                {
                    result = new ProgressStatus { Message = "You allredy sent a Request", Number = 2, Title = "unSuccessful" };
                    return result;
                }
            }
            catch (Exception ex)
            {
                result = new ProgressStatus { Message = ex.Message, Number = 0, Title = "" };
                return result;
            }
        }
    }
}
