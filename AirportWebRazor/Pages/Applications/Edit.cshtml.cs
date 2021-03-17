using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace AirportWebRazor.Pages.Applications
{
    public class EditModel : PageModel
    {
        private readonly ILinks _link;
        private readonly ICategory _category;

        public EditModel(ILinks links, ICategory category)
        {
            _link = links;
            _category = category;
        }

        [BindProperty]
        public AirPortModel.Models.Links linkesobj { get; set; }

        public async Task<IActionResult> OnGet(int id)
        {
            linkesobj = _link.FindById(id);
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
                    }


                    linkesobj.CategoryId = 14;
                }
                if (_link.Update(linkesobj).Number.Equals(1))
                {
                    return RedirectToPage("Index");
                }
                else
                {
                    return Redirect("index");
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
