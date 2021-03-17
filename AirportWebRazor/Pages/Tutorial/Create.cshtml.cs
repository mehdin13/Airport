using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace AirportWebRazor.Pages.Tutorial
{
    public class CreateModel : PageModel
    {
        private readonly ILinks _link;
        private readonly ICategory _category;

        public CreateModel(ILinks links, ICategory category)
        {
            _link = links;
            _category = category;
        }

        [BindProperty]
        public AirPortModel.Models.Links linkesobj { get; set; }

        public async Task<IActionResult> OnGet()
        {
            return Page();
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
                        linkesobj.Icon = string.Format("{0}{1}", "\\", path);

                        linkesobj.CategoryId = 13;
                        _link.Insert(linkesobj);
                    }
                    return RedirectToPage("Index");
                }

                else
                {

                    return Redirect("Index");
                }
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                return Page();
            }
        }
    }
}
