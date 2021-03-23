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
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
                faqOBJ = _faq.FindById(id);
                return Page();
            }
        }

        public async Task<IActionResult> OnPost()
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
}
