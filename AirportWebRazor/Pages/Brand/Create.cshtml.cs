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
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
                return Page();
            }
        }


        public async Task<IActionResult> OnPost(IFormFile images)
        {
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
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
                        var path = Path.Combine("images", string.Format("{0}{1}", Guid.NewGuid().ToString().Replace("_", ""), Path.GetExtension(images.FileName)));
                        using (var stream = new FileStream(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\", path), FileMode.Create))
                        {
                            images.CopyTo(stream);
                            brand1.BrandIcon = string.Format("{0}{1}", "\\", path);
                            _brand.Insert(brand1);
                        }

                    }
                    else
                    {
                        return Page();
                    }
                    return Redirect("Index");
                }
                catch (Exception ex)
                {
                    _ = ex.Message;
                    return Page();
                }
            }
        }
    }
}
