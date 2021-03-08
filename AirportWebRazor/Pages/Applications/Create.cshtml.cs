using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;

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
        public async Task<IActionResult> OnPost()
        {
            linksOBJs.CategoryId = 14;
            try
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }
                else
                {
                    _links.Insert(linksOBJs);
                    return RedirectToPage("index");
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
