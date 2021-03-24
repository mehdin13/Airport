using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Http;

namespace AirportWebRazor.Pages.Detail
{
    public class CreatModel : PageModel
    {

        private readonly IDetail _detail;
        private readonly ITypeDetail _typeDetail;

        public CreatModel(IDetail detail,ITypeDetail typeDetail)
        {
            _detail = detail;
            _typeDetail = typeDetail;
        }
        [BindProperty]
        public AirPortModel.Models.Detail detail1 { get; set; }


        public async Task<IActionResult> OnGet()
        {
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
                ViewData["detail"] = _typeDetail.ToList();
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
                        _detail.Insert(detail1);
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
