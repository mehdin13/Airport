using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;

namespace AirportWebRazor.Pages.TypeDetal
{
    public class IndexModel : PageModel
    {

        private readonly ITypeDetail _typeDetail;

        public IndexModel(ITypeDetail typeDetail)
        {
            _typeDetail = typeDetail;
        }
        public List<AirPortModel.Models.TypeDetail> typeDetails { get; set; }

        public async Task<IActionResult> OnGet()
        {
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
                typeDetails = _typeDetail.ToList();
                return Page();
            }
        }
        public async Task<IActionResult> OnPost(int id)
        {
            _typeDetail.Delete(id);
            return RedirectToPage("index");
        }
    }
}
