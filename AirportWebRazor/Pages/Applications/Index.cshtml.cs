using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;

namespace AirportWebRazor.Pages.Applications
{
    public class IndexModel : PageModel
    {
        private readonly ILinks _link;
        private readonly ICategory _category;

        public IndexModel(ILinks links,ICategory category)
        {
            _link = links;
            _category = category;
        }

        [BindProperty]
        public List<AirPortModel.Models.Links> linksOBJ { get; set; }

        public async Task<IActionResult> OnGet()
        {
            linksOBJ = _link.ToList();
            return Page();
        }
        public async Task<IActionResult> OnPost(int id)
        {
            _link.Delete(id);
            return RedirectToPage("index");
        }
    }
}