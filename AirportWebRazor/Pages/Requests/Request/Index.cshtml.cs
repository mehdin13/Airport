using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Http;

namespace AirportWebRazor.Pages.Requests.RequestHotel
{
    public class IndexModel : PageModel
    {
        private readonly IRequest _request;
        private readonly IRequestType _requestType;
        private readonly ICustomer _customer;


        public IndexModel(IRequest request,IRequestType requestType,ICustomer customer)
        {
            _request = request;
            _requestType = requestType;
            _customer = customer;
        }

        [BindProperty]
        public List<AirPortModel.Models.Request> requestsobj { get; set; }

        public async Task<IActionResult> OnGet()
        {
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
                ViewData["Requesttypes"] = _requestType.ToList();
                ViewData["Customer"] = _customer.ToList();
                requestsobj = _request.ToList();
                return Page();
            }
        }
        public async Task<IActionResult> OnPost(int id)
        {
            _request.Delete(id);
            return Page();
        }
    }
}
