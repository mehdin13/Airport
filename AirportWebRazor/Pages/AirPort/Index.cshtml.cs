using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Http;

namespace AirportWebRazor.Pages.AirPort
{
    public class IndexModel : PageModel
    {
        private readonly IAirPort _airPort;
        private readonly IAddress _address;
        private readonly IGallery _gallery;
        private readonly IGalleryImage _galleryImage;
        private readonly ICity _city;
        
        public IndexModel(IAirPort airPort,IAddress address, IGallery gallery, IGalleryImage galleryImage, ICity city)
        {
            _airPort = airPort;
            _address = address;
            _gallery = gallery;
            _galleryImage = galleryImage;
            _city = city;
        }

        [BindProperty]
        public List<AirPortModel.Models.AirPort> airPorts { get; set; }

        public async Task<IActionResult> OnGet()
        {
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
                ViewData["airport"] = _airPort.Tolist();
                ViewData["address"] = _address.ToList();
                ViewData["City"] = _city.ToList();
                ViewData["Gallery"] = _gallery.ToList();
                ViewData["GalleryImage"] = _galleryImage.ToList();
                airPorts = _airPort.Tolist();
                return Page();
            }
        }

        public async Task<IActionResult> OnPost(int id)
        {
            _airPort.Delete(id);
            return RedirectToPage("index");
        }
    }
}
