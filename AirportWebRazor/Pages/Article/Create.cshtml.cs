using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;

namespace AirportWebRazor.Pages.Article
{
    public class CreateModel : PageModel
    {
        private readonly IArticle _article;
        private readonly IGallery _gallery;

        public CreateModel(IArticle article,IGallery gallery)
        {
            _article = article;
            _gallery = gallery;
        }

        [BindProperty]
        public AirPortModel.Models.Article article1 { get; set; }

        public async Task<IActionResult> OnGet()
        {
            ViewData["Galleryes"] = _gallery.ToList();
            return Page();
        }

        public async Task<IActionResult> Onpost()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }
                else
                {
                    _article.Insert(article1);
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
