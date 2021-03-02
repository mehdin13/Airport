using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;

namespace AirportWebRazor.Pages.Gallery
{
    public class CreateModel : PageModel
    {
        private readonly IGallery _gallery;

        public CreateModel(IGallery gallery)
        {
            _gallery = gallery;
        }

        [BindProperty]
        public AirPortModel.Models.Gallery gallery1 { get; set; }

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
                    _gallery.Insert(gallery1);
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
