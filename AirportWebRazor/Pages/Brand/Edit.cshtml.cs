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
    public class EditModel : PageModel
    {
        private readonly IBrand _brand;

        public EditModel(IBrand brand)
        {
            _brand = brand;
        }

        [BindProperty]
        public AirPortModel.Models.Brand brandObj { get; set; }

        public async Task<IActionResult> OnGet(int id)
        {
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
                brandObj = _brand.FindById(id);
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

                    //Logo
                    if (images.Length > 0 && images.ContentType != null)
                    {
                        var path = Path.Combine("images", string.Format("{0}{1}", Guid.NewGuid().ToString().Replace("_", ""), Path.GetExtension(images.FileName)));
                        using (var stream = new FileStream(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\", path), FileMode.Create))
                        {
                            images.CopyTo(stream);
                            brandObj.BrandIcon = string.Format("{0}{1}", "\\", path);

                        }
                        if (_brand.Update(brandObj).Number.Equals(1))
                        {
                            return RedirectToPage("index");
                        }
                        else
                        {
                            return Page();
                        }
                    }
                    return RedirectToPage("Index");
                }
                catch (Exception ex)
                {
                    string mes = ex.Message;
                    return Redirect("Index");
                }
            }
        }
    }
}
