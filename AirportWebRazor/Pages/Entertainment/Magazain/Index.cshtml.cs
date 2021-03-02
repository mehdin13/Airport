using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;

namespace AirportWebRazor.Pages.Entertainment.Magazain
{
    public class IndexModel : PageModel
    {
        private readonly IEntertainment _entertainment;

        public IndexModel(IEntertainment entertainment)
        {
            _entertainment = entertainment;
        }

        [BindProperty]
        public List<AirPortModel.Models.Entertainment> entertainments { get; set; }

        public async Task<IActionResult> OnGet()
        {
            entertainments = _entertainment.ToList();
            return Page();
        }
    }
}
