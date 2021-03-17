using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace AirportWebRazor.Pages.Applications
{
    public class CreateModel : PageModel
    {
        private readonly ILinks _links;
        private readonly ICategory _category;

        public CreateModel(ILinks links, ICategory category)
        {
            _links = links;
            _category = category;
        }
        [BindProperty]
        public AirPortModel.Models.Links linksOBJs { get; set; }

        public async Task<IActionResult> OnGet()
        {
            return Page();
        }
        public async Task<IActionResult> OnPost(IFormFile images)
        {
            linksOBJs.CategoryId = 14;
            try
            {
                if (images.Length > 0 && images.ContentType != null)
                {
                    var path = Path.Combine("images", string.Format("{0}{1}", Guid.NewGuid().ToString().Replace("_", ""), Path.GetExtension(images.FileName)));
                    using (var stream = new FileStream(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\", path), FileMode.Create))
                    {
                        images.CopyTo(stream);
                        linksOBJs.Icon = string.Format("{0}{1}", "\\", path);
                    }
                    _links.Insert(linksOBJs);
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
