using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Http;

namespace AirportWebRazor.Pages.Places.Restaurant
{
    public class IndexModel : PageModel
    {

        private readonly IPlace _place;
        private readonly ICategory _category;
        private readonly IAddress _address;
        private readonly IDetail _detail;
        private readonly IGallery _gallery;
        private readonly IGalleryImage _galleryImage;

        public IndexModel(IPlace place, ICategory category, IAddress address, IDetail detail, IGallery gallery, IGalleryImage galleryImage)
        {
            _place = place;
            _category = category;
            _address = address;
            _detail = detail;
            _gallery = gallery;
            _galleryImage = galleryImage;
        }
        [BindProperty]
        public List<AirPortModel.Models.Place> places { get; set; }


        public async Task<IActionResult> OnGet()
        {
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
                ViewData["Address"] = _address.ToList();
                ViewData["Detail"] = _detail.ToList();
                ViewData["Galleryes"] = _gallery.ToList();
                ViewData["Galleryimages"] = _galleryImage.ToList();

                places = _place.ToList();

                return Page();
            }
        }

        public async Task<IActionResult> OnPost(int id)
        {
            _place.Delete(id);
            return RedirectToPage("index");
        }
    }
}
