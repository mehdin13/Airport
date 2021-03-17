using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;

namespace AirportWebRazor.Pages.GalleryImage
{
    public class IndexModel : PageModel
    {
        private readonly IGalleryImage _galleryimage;
        private readonly IGallery _gallery;

        public IndexModel(IGalleryImage galleryImage, IGallery gallery)
        {
            _galleryimage = galleryImage;
            _gallery = gallery;
        }

        [BindProperty]
        public List<AirPortModel.Models.GalleryImage> galleryImages { get; set; }

        public async Task<IActionResult> OnGet(int id)
        {
            galleryImages = _galleryimage.ToList().Where(x => x.GalleryId.Equals(id)).ToList();
            return Page();
        }

        public async Task<IActionResult> OnPost(int id)
        {
            _galleryimage.Delete(id);
            return RedirectToPage("Index");
        }
    }
}
