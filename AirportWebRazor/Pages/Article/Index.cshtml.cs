using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Http;

namespace AirportWebRazor.Pages.Article
{
    public class IndexModel : PageModel
    {
        private readonly IArticle _article;
        private readonly IGallery _gallery;
        private readonly IGalleryImage _galleryImage;

        public IndexModel(IArticle article, IGallery gallery,IGalleryImage galleryImage)
        {
            _article = article;
            _gallery = gallery;
            _galleryImage = galleryImage;
        }

        [BindProperty]
        public List<AirPortModel.Models.Article> articles { get; set; }

        public async Task<IActionResult> OnGet()
        {
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
                ViewData["Galery"] = _gallery.ToList();
                ViewData["Galleryimages"] = _galleryImage.ToList();
                articles = _article.ToList();
                return Page();
            }
        }

        public async Task<IActionResult> OnPost(int id)
        {
            
            _article.Delete(id);
            return RedirectToPage("index");
        }
    }
}
