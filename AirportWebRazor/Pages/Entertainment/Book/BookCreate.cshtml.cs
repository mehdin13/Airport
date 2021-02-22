using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace AirportWebRazor.Pages.Entertainment.Book
{
    public class BookCreateModel : PageModel
    {
        private readonly IEntertainment _entertainment;
        private readonly IGallery _gallery;
        private readonly ILinks _links;
        private readonly IGalleryImage _Galleryimage;
        public BookCreateModel(IEntertainment entertainment, IGallery gallery, ILinks links, IGalleryImage galleryImage)
        {
            _entertainment = entertainment;
            _gallery = gallery;
            _links = links;
            _Galleryimage = galleryImage;
        }

        [BindProperty]
        public AirPortModel.Models.Links Links { get; set; }
        public AirPortModel.Models.Gallery Gallery { get; set; }
        public AirPortModel.Models.GalleryImage GalleryImage { get; set; }
        public AirPortModel.Models.Entertainment entertainment { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            #region link add
            Links.CategoryId = 2;
            #endregion
            Links.CategoryId = 2;
            _links.Insert(Links);
            _gallery.Insert(Gallery);
            _Galleryimage.Insert(GalleryImage);
            _entertainment.Insert(entertainment);


            return RedirectToPage("BookList");
        }

    }
}
