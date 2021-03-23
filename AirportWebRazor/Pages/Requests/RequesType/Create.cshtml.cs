using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;

namespace AirportWebRazor.Pages.Requests.RequesType
{
    public class CreateModel : PageModel
    {
        private readonly IRequestType _requesttype;

        public CreateModel(IRequestType requestType)
        {
            _requesttype = requestType;
        }

        [BindProperty]
        public AirPortModel.Models.RequestType requestTypeobje { get; set; }

        public async Task<IActionResult> OnGet()
        {
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
                return Page();
            }
        }

        public async Task<IActionResult> OnPost()
        {
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
                try
                {
                    if (!ModelState.IsValid)
                    {
                        return Page();
                    }
                    else
                    {
                        _requesttype.Insert(requestTypeobje);
                        return Redirect("Index");
                    }
                }
                catch (Exception ex)
                {
                    string mes = ex.Message;
                    return Page();
                }
            }
        }
    }
}
