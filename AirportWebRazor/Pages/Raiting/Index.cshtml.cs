using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;

namespace AirportWebRazor.Pages.Raiting
{
    public class IndexModel : PageModel
    {
        private readonly IRaiting _raiting;
        private readonly ICustomer _customer;
        private readonly IDetail _detail;

        public IndexModel(IRaiting raiting, ICustomer customer, IDetail detail)
        {
            _raiting = raiting;
            _customer = customer;
            _detail = detail;
        }

        [BindProperty]
        public List<AirPortModel.Models.Raiting> raitings { get; set; }

        public async Task<IActionResult> OnGet()
        {
            ViewData["Customers"] = _customer.ToList();
            ViewData["Detailes"] = _detail.ToList();


            raitings = _raiting.ToList();
            return Page();
        }
    }
}
