using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Http;
using System.IO;


namespace AirportWebRazor.Pages.Padcast
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
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", string.Format("{0}{1}", Guid.NewGuid().ToString().Replace("_", ""), Path.GetExtension(images.FileName)));
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        images.CopyTo(stream);
                        linkesobj.Icon = filePath;
                        linkesobj.CategoryId = 11;
                    }
                    if (_link.Update(linkesobj).Number.Equals(1))
                    {
                        return RedirectToPage("index");
                    }
                    else
                    {
                        return Page();
                    }


                }
                return Redirect("index");
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                return Page();
            }
        }
    }
}
