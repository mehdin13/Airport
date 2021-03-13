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
            return Page();
        }

        public async Task<IActionResult> OnPost()
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
