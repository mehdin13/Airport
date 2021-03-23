using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace AirportWebRazor.Pages.Featrue
{
    public class CreateModel : PageModel
    {
        private readonly IFeatrue _featrue;
        private readonly ITypeDetail _typeDetail;
        public CreateModel(IFeatrue featrue , ITypeDetail typeDetail)
        {
            _featrue = featrue;
            _typeDetail = typeDetail;
        }
        [BindProperty]
        public AirPortModel.Models.Featrue featrue1 { get; set; }

        public async Task<IActionResult> OnGet()
        {
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
                ViewData["detail"] = _typeDetail.ToList();
                return Page();
            }
        }

        public async Task<IActionResult> OnPost(IFormFile images)
        {
            try
            {
                if (images.Length > 0 && images.ContentType != null)
                {
                    var path = Path.Combine("images", string.Format("{0}{1}", Guid.NewGuid().ToString().Replace("_", ""), Path.GetExtension(images.FileName)));
                    using (var stream = new FileStream(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\", path), FileMode.Create))
                    {
                        images.CopyTo(stream);
                        featrue1.Icon = string.Format("{0}{1}", "\\", path);
                    }
                    _featrue.Insert(featrue1);
                    return Redirect("index");
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
