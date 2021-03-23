using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Http;

namespace AirportWebRazor.Pages.AirPlane
{
    public class IndexModel : PageModel
    {
        private readonly IAirPlane _airplane;
        private readonly IBrand _brand;

        public IndexModel(IAirPlane airPlane,IBrand brand)
        {
            _airplane = airPlane;
            _brand = brand;
        }

        [BindProperty]
        public List<AirPortModel.Models.AirPlane> airPlanes { get; set; }

        public async Task<IActionResult> OnGet()
        {
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
                ViewData["Brandes"] = _brand.ToList();
                airPlanes = _airplane.ToList();
                return Page();
            }
        }

        public async Task<IActionResult> OnPost(int id)
        {
            _airplane.Delete(id);
            return RedirectToPage("index");
        }
    }
}
