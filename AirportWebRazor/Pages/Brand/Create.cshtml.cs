using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Http;
using System.IO;

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


        public async Task<IActionResult> OnPost(IFormFile images)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }
                //Logo
               else if (images.Length > 0 && images.ContentType != null)
                {
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", string.Format("{0}{1}", Guid.NewGuid().ToString().Replace("_", ""), Path.GetExtension(images.FileName)));
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        images.CopyTo(stream);
                        brand1.BrandIcon = filePath;
                    }
                    _brand.Insert(brand1);
                    return RedirectToPage("index");
                }
                else
                {
                    return Page();
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
