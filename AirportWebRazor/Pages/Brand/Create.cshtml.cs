using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;

namespace AirportWebRazor.Pages.Brand
{
    public class CreateModel : PageModel
    {
        private readonly IBrand _brand;

        public CreateModel(IBrand brand)
        {
            _brand = brand;
        }

        [BindProperty]
        public AirPortModel.Models.Brand brand1 { get; set; }

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
                    _brand.Insert(brand1);
                    return RedirectToPage("index");
                }
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                return Page();
            }
        }
    }
}
