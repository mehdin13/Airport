using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;


namespace AirportWebRazor.Pages.DitailValue
{
    public class CreateModel : PageModel
    {
        private readonly IDetailValue _detailValue;
        private readonly IDetail _detail;
        private readonly IFeatrue _featrue;
        private readonly ITypeDetail _typedetail;

        public CreateModel(IDetailValue detailValue , IDetail detail , IFeatrue featrue,ITypeDetail typeDetail)
        {
            _detailValue = detailValue;
            _detail = detail;
            _featrue = featrue;
            _typedetail = typeDetail;
        }

        [BindProperty]
        public AirPortModel.Models.DetailValue DetailValue { get; set; }

        public async Task<IActionResult> OnGet()
        {
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
                ViewData["detail"] = _featrue.ToList();
                ViewData["detail1"] = _detail.ToList();
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
                        _detailValue.Insert(DetailValue);
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
}
