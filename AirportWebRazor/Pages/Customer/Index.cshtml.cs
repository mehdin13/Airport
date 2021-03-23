using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;

namespace AirportWebRazor.Pages.Customer
{
    public class IndexModel : PageModel
    {
        private readonly ICustomer _customer;
        private readonly IAddress _address;

        public IndexModel(ICustomer customer, IAddress address)
        {
            _customer = customer;
            _address = address;
        }
        [BindProperty]
        public List<AirPortModel.Models.Customer> customers { get; set; }

        public async Task<IActionResult> OnGet()
        {
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
                ViewData["Addresses"] = _address.ToList();

                customers = _customer.ToList();
                return Page();
            }
        }
    }
}
