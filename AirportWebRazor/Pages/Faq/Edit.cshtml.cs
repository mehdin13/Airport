using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;

namespace AirportWebRazor.Pages.Faq
{
    public class EditModel : PageModel
    {
        private readonly IFaq _faq;

        public EditModel(IFaq faq)
        {
            _faq = faq;
        }

        [BindProperty]
        public AirPortModel.Models.Faq faqOBJ { get; set; }


        public async Task<IActionResult> OnGet(int id)
        {
            faqOBJ = _faq.FindById(id);
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            try
            {
                if (_faq.Update(faqOBJ).Number.Equals(1))
                {
                    return RedirectToPage("index");
                }
                else
                {
                    return RedirectToPage("index");
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
