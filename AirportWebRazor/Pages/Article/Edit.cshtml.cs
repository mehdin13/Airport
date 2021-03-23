using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace AirportWebRazor.Pages.Article
{
    public class EditModel : PageModel
    {
        private readonly IArticle _article;
        private readonly IGallery _gallery;
        private readonly IGalleryImage _galleryImage;

        public EditModel(IArticle article, IGallery gallery, IGalleryImage galleryImage)
        {
            _article = article;
            _gallery = gallery;
            _galleryImage = galleryImage;
        }

        [BindProperty]
        public AirPortModel.Models.Article articleObj { get; set; }


        public async Task<IActionResult> OnGet(int id)
        {
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
                articleObj = _article.FindById(id);
                ViewData["Galleryes"] = _gallery.FindById(id);
                return Page();
            }
        }

        public async Task<IActionResult> OnPost(string[] value, IFormFile images, IFormFile mapimage)
        {
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
                try
                {

                    if (_article.Update(articleObj).Number.Equals(1))
                    {
                        return Redirect("index");
                    }
                    else
                    {
                        return Redirect("index");
                    }
                }
                catch (Exception ex)
                {
                    string massage = ex.Message;
                    return Redirect("index");
                }
            }
        }
    }
}
