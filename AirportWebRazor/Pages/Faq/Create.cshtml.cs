using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;
using AirPortModel.Models;

namespace AirportWebRazor.Pages.Faq
{
    public class CreateModel : PageModel
    {
        private readonly IFaq _faq;

        public CreateModel(IFaq faq)
        {
            _faq = faq;
        }
        [BindProperty]
        public AirPortModel.Models.Faq faqs1 { get; set; }

        public async Task<IActionResult> OnGet()
        {
            return Page();
        }
        public async Task<IActionResult> OnPost()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }
                else
                {
                    _faq.Insert(faqs1);
                    return Redirect("index");
                }
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                return Page();
            }
        }
    }
}
