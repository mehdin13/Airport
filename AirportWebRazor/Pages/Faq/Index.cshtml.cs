using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;


namespace AirportWebRazor.Pages.Faq
{
    public class IndexModel : PageModel
    {
        private readonly IFaq _faq;

        public IndexModel(IFaq faq)
        {
            _faq = faq;
        }

        public List<AirPortModel.Models.Faq> faqs { get; set; }

        public async Task<IActionResult> OnGet()
        {
            faqs = _faq.ToList();

            return Page();
        }
        public async Task<IActionResult> OnPost(int id)
        {
            _faq.Delete(id);
            return RedirectToPage("index");
        }
    }
}
