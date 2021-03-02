using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;

namespace AirportWebRazor.Pages.Request
{
    public class IndexModel : PageModel
    {
        private readonly IRequest _request;
        private readonly IRequestType _requestType;

        public IndexModel(IRequest request, IRequestType requestType)
        {
            _request = request;
            _requestType = requestType;
        }

        [BindProperty]
        public List<AirPortModel.Models.Request> requests { get; set; }

        public async Task<IActionResult> OnGet()
        {
            ViewData["requesttype"] = _requestType.ToList();

            requests = _request.ToList();
            return Page();
        }
    }
}
