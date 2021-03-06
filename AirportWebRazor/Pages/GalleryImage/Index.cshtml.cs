using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Http;

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
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
                ViewData["id"] = id;
                galleryImages = _galleryimage.ToList().Where(x => x.GalleryId.Equals(id)).ToList();
                return Page();
            }
        }

        public async Task<IActionResult> OnPost(int id)
        {
            _galleryimage.Delete(id);
            return RedirectToPage("Index");
        }
    }
}
