using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;

namespace AirportWebRazor.Pages.Padcast
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

                    linkesobj.CategoryId = 11;
                    _link.Insert(linkesobj);
                    return Redirect("Index");
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
