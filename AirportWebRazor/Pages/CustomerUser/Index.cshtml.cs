using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Http;

namespace AirportWebRazor.Pages.CustomerUser
{
    public class IndexModel : PageModel
    {
        private readonly IUser _user;
        private readonly ICustomer _customer;

        public IndexModel(IUser user, ICustomer customer)
        {
            _user = user;
            _customer = customer;
        }

        [BindProperty]
        public List<AirPortModel.Models.User> users { get; set; }

        public async Task<IActionResult> OnGet()
        {
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
                ViewData["Customers"] = _customer.ToList();

                users = _user.ToList();
                return Page();
            }
        }
    }
}
