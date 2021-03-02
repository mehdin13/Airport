using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;

namespace AirportWebRazor.Pages.Gallery
{
    public class IndexModel : PageModel
    {
        private readonly IGallery _gallery;

        public IndexModel(IGallery gallery)
        {
            _gallery = gallery;
        }
        [BindProperty]
        public List<AirPortModel.Models.Gallery> galleries { get; set; }

        public async Task<IActionResult> OnGet()
        {
            galleries = _gallery.ToList();
            return Page();
        }

    }
}
