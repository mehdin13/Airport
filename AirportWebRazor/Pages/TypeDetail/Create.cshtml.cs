using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Http;

namespace AirportWebRazor.Pages.TypeDetail
{
    public class CreateModel : PageModel
    {
        private readonly ITypeDetail _typeDetail;

        public CreateModel(ITypeDetail typeDetail)
        {
            _typeDetail = typeDetail;
        }
        [BindProperty]
        public AirPortModel.Models.TypeDetail TypeDetail { get; set; }

        public async Task<IActionResult> OnGet()
        {
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
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
                    if (!ModelState.IsValid)
                    {
                        return Page();
                    }
                    else
                    {
                        _typeDetail.Insert(TypeDetail);
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
}
