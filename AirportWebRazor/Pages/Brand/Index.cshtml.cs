using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Http;

namespace AirportWebRazor.Pages.Brand
{
    public class IndexModel : PageModel
    {
        private readonly IBrand _brand;

        public IndexModel(IBrand brand)
        {
            _brand = brand;
        }

        [BindProperty]
        public List<AirPortModel.Models.Brand> brands { get; set; }

        public async Task<IActionResult> OnGet()
        {
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
                brands = _brand.ToList();
                return Page();
            }
        }


        public async Task<IActionResult> OnPost(int id)
        {
            _brand.Delete(id);
            return RedirectToPage("index");
        }
    }
}
