using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Http;

namespace AirportWebRazor.Pages.Requests.RequesType
{
    public class IndexModel : PageModel
    {
        private readonly IRequestType _requesttype;

        public IndexModel(IRequestType requestType)
        {
            _requesttype = requestType;
        }

        [BindProperty]
        public List<AirPortModel.Models.RequestType> requestTypesOBJ { get; set; }

        public async Task<IActionResult> OnGet()
        {
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
                requestTypesOBJ = _requesttype.ToList();
                return Page();
            }
        }


        //Delete Nemikhad chon sabete Create ham nemikhad aslan mesle CATEGORY hast:D

        //public async Task<IActionResult> OnPost(int id)
        //{
        //     _requesttype.Delete(id);
        //    return Page();
        //}

        //End Delete
    }
}
