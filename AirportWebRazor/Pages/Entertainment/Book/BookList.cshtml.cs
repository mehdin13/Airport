using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using AirportWebRazor.Model.ViewMode;
using Microsoft.EntityFrameworkCore;

namespace AirportWebRazor.Pages.Entertainment.Book
{
    public class BookListModel : PageModel
    {

        private readonly IEntertainment _entertainment;
        private readonly IGallery _gallery;
        private readonly IGalleryImage _galleryImage;
        private readonly ICategory _category;
        private readonly ILinks _links;


        public BookListModel(IEntertainment entertainment, IGallery gallery, IGalleryImage galleryImage, ICategory category, ILinks links)
        {
            _entertainment = entertainment;
            _gallery = gallery;
            _galleryImage = galleryImage;
            _category = category;
            _links = links;
        }
        [BindProperty]
        public List<AirPortModel.Models.Entertainment> entertainments { get; set; }

        public async Task<IActionResult> OnGet()
        {
            ViewData["Gallery"] = _gallery.ToList();
            ViewData["Linkes"] = _links.ToList();

            entertainments = _entertainment.EntertainmentBookId();
            return Page();
        }
        public async Task<IActionResult> OnPost(int id)
        {
            _entertainment.Delete(id);
            return RedirectToPage("index");
        }
    }
}
