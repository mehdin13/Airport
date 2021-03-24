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
    public class IndexModel : PageModel
    {

        private readonly IDetail _detail;

        public IndexModel(IDetail detail)
        {
            _detail = detail;
        }
        [BindProperty]
        public List<AirPortModel.Models.Detail> details { get; set; }
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
                details = _detail.ToList();
                return Page();
            }
        }

        public async Task<IActionResult> OnPost(int id)
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

                    _detail.Delete(id);
                    return RedirectToPage("index");
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
