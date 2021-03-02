using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;

namespace AirportWebRazor.Pages.Article
{
    public class IndexModel : PageModel
    {
        private readonly IArticle _article;
        private readonly IGallery _gallery;

        public IndexModel(IArticle article, IGallery gallery)
        {
            _article = article;
            _gallery = gallery;
        }

        [BindProperty]
        public List<AirPortModel.Models.Article> articles { get; set; }
        public async Task<IActionResult> OnGet()
        {
            ViewData["Galery"] = _gallery.ToList();
            articles = _article.ToList();
            return Page();
        }

        public async Task<IActionResult> OnPost(int id)
        {
            
            _article.Delete(id);
            return RedirectToPage("index");
        }
    }
}
