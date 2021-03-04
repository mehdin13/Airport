using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;

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
            brands = _brand.ToList();
            return Page();
        }


        public async Task<IActionResult> OnPost(int id)
        {
            _brand.Delete(id);
            return RedirectToPage("index");
        }
    }
}
