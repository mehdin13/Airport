using System;
using System.Linq;
using AirPort.Model.ViewModel;
using AirPortDataLayer.Crud;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Mvc;

namespace AirPort.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RequestController : Controller
    {
        private readonly IRequest _request;
        private readonly IRequestSizePolicy _requesttype;
        private readonly ICustomer _customer;

        public RequestController(IRequest request, IRequestType requestType, ICustomer customer)
        {

            _request = request;

            _customer = customer;

        }


        [HttpPost]
        [Route("Requestes")]
        public ProgressStatus Requestes([FromForm] Requests Request)
        {

            try
            {

                AirPortModel.Models.Request Requestobj = new AirPortModel.Models.Request();
                string Custumerid = User.Claims.First(u => u.Type == "Customer").Value;
                var Userobj = _customer.FindById(Convert.ToInt32(Custumerid));
                if (Userobj != null)
                {
                    Requestobj.Title = Request.title;
                    Requestobj.Description = Request.Description;
                    Requestobj.CustomerId = Userobj.Id;
                    _request.Insert(Requestobj);
                    var result = new ProgressStatus { Message = "درخواست با موفقیت ثبت شد", Number = 1, Title = "Successful" };
                    return result;
                }
                else
                {
                    var result = new ProgressStatus { Message = "لطفا مقادیر خالی را پر کنید", Number = 2, Title = "unSuccessful" };
                    return result;
                }
            }
            catch (Exception ex)
            {
               var result = new ProgressStatus { Message = ex.Message, Number = 0, Title = "" };
                return result;
            }
        }

    }
}
