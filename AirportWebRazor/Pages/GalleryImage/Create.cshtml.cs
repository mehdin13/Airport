using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;


namespace AirportWebRazor.Pages.GalleryImage
{
    public class CreateModel : PageModel
    {
        private readonly IGalleryImage _galleryImage;
        private readonly IGallery  _gallery;

        public CreateModel(IGalleryImage galleryImage, IGallery gallery)
        {
            _galleryImage = galleryImage;
            _gallery = gallery;
        }
        [BindProperty]
        public AirPortModel.Models.GalleryImage galleryImage1 { get; set; }

        public async Task<IActionResult> OnGet()
        {
            ViewData["GalleryImages"] = _gallery.ToList();
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
                    _galleryImage.Insert(galleryImage1);
                    return Redirect("index");
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
